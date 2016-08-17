using Contoso.Events.Data;
using Contoso.Events.Models;
using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Web.Configuration;
using System.Configuration;

namespace Contoso.Events.ViewModels
{
    public class SignInSheetViewModel
    {
        private const string PROCESSING_URI = "uri://processing";

        public SignInSheetViewModel()
        { }

        public SignInSheetViewModel(string eventKey)
        {
            this.SignInSheetState = default(SignInSheetState);

            using (EventsContext context = new EventsContext())
            {
                var eventItem = context.Events.SingleOrDefault(e => e.EventKey == eventKey);

                this.Event = eventItem;

                if (this.Event.SignInDocumentUrl == PROCESSING_URI)
                {
                    this.SignInSheetState = SignInSheetState.SignInDocumentProcessing;
                }
                else if (!String.IsNullOrEmpty(this.Event.SignInDocumentUrl))
                {
                    this.SignInSheetState = SignInSheetState.SignInDocumentAlreadyExists;
                }
                else
                {
                    GenerateSignInSheetTableStorage(context, eventItem);
                }
            }
        }

        private void GenerateSignInSheetServiceBus(EventsContext context, Event eventItem)
        {
            string serviceBusConnectionString = WebConfigurationManager.AppSettings["Microsoft.ServiceBus.ConnectionString"];
            string signInQueueName = WebConfigurationManager.AppSettings["SignInQueueName"];
            NamespaceManager namespaceManager = NamespaceManager.CreateFromConnectionString(serviceBusConnectionString);
            QueueClient client = QueueClient.CreateFromConnectionString(serviceBusConnectionString, signInQueueName);
            client.Send(
                new BrokeredMessage(
                    new QueueMessage
                    {
                        EventId = eventItem.Id,
                        MessageType = QueueMessageType.SignIn
                    }
                )
            );

            eventItem.SignInDocumentUrl = PROCESSING_URI;

            context.SaveChanges();

            this.Event = eventItem;

            this.SignInSheetState = SignInSheetState.SignInDocumentProcessing;
        }

        private void GenerateSignInSheetTableStorage(EventsContext context, Event eventItem)
        {
            string connectionString = ConfigurationManager.AppSettings["Microsoft.WindowsAzure.Storage.ConnectionString"];
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(connectionString);
            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();

            string signInQueueName = ConfigurationManager.AppSettings["SignInQueueName"];
            CloudQueue queue = queueClient.GetQueueReference(signInQueueName);
            queue.CreateIfNotExists();

            string queueMessage = JsonConvert.SerializeObject(
                new QueueMessage
                {
                    EventId = eventItem.Id,
                    MessageType = QueueMessageType.SignIn
                }
            );

            queue.AddMessage(
                new CloudQueueMessage(queueMessage)
            );

            eventItem.SignInDocumentUrl = PROCESSING_URI;

            context.SaveChanges();

            this.Event = eventItem;

            this.SignInSheetState = SignInSheetState.SignInDocumentProcessing;
        }

        public void GenerateSignInSheet(int eventId)
        {
            using (EventsContext context = new EventsContext())
            {
                var eventItem = context.Events.SingleOrDefault(e => e.Id == eventId);

                eventItem.SignInDocumentUrl = PROCESSING_URI;

                context.SaveChanges();

                this.Event = eventItem;
            }

            this.SignInSheetState = SignInSheetState.SignInDocumentProcessing;
        }

        public Event Event { get; set; }

        public SignInSheetState SignInSheetState { get; set; }
    }

    public enum SignInSheetState
    {
        Unknown = 0,
        SignInDocumentProcessing,
        SignInDocumentAlreadyExists
    }
}