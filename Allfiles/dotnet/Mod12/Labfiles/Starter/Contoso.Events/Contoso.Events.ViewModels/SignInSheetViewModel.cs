using Contoso.Events.Data;
using Contoso.Events.Models;
using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Web.Configuration;

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
                    QueueMessage message = new QueueMessage
                    {
                        EventId = eventItem.Id,
                        MessageType = QueueMessageType.SignIn
                    };
                    string messageString = JsonConvert.SerializeObject(message);

                    GenerateSignInSheetTableStorage(context, eventItem, messageString);
                }
            }
        }

        private string tableStorageConnectionString = WebConfigurationManager.AppSettings["Microsoft.WindowsAzure.Storage.ConnectionString"];
        private string serviceBusConnectionString = WebConfigurationManager.AppSettings["Microsoft.ServiceBus.ConnectionString"];
        private string signInQueueName = WebConfigurationManager.AppSettings["SignInQueueName"];

        private void GenerateSignInSheetServiceBus(EventsContext context, Event eventItem, QueueMessage message)
        {
            QueueClient client = QueueClient.CreateFromConnectionString(serviceBusConnectionString, signInQueueName);

            BrokeredMessage queueMessage = new BrokeredMessage(message);
            client.Send(queueMessage);

            eventItem.SignInDocumentUrl = PROCESSING_URI;

            context.SaveChanges();

            this.Event = eventItem;

            this.SignInSheetState = SignInSheetState.SignInDocumentProcessing;
        }

        private void GenerateSignInSheetTableStorage(EventsContext context, Event eventItem, string message)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(tableStorageConnectionString);
            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();

            CloudQueue queue = queueClient.GetQueueReference(signInQueueName);
            queue.CreateIfNotExists();

            CloudQueueMessage queueMessage = new CloudQueueMessage(message);
            queue.AddMessage(queueMessage);

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