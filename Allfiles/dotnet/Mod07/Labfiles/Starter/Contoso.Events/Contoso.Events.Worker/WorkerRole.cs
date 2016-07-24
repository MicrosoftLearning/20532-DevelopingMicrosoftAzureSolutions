using Contoso.Events.Data;
using Contoso.Events.Documents;
using Contoso.Events.Models;
using Microsoft.ServiceBus.Messaging;
using Microsoft.WindowsAzure.ServiceRuntime;
using Microsoft.WindowsAzure.Storage.Queue;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;

namespace Contoso.Events.Worker
{
    /// TODO: Exercise 10.2: Create an Azure Queue Storage instance 
    /// TODO: Exercise 10.4: Create a Service Bus Queue 
    public class WorkerRole : RoleEntryPoint
    {
        private readonly SignInDocumentGenerator _documentGenerator = new SignInDocumentGenerator();
        private readonly BlobStorageHelper _blobHelper = new BlobStorageHelper();
        private readonly TableStorageHelper _tableHelper = new TableStorageHelper();
        private readonly IQueueHelper<CloudQueueMessage> _queueHelper = new TableStorageQueueHelper();

        public override void Run()
        {
            while (true)
            {
                Thread.Sleep(10000);

                Trace.WriteLine("Queue Run Iteration");

                CloudQueueMessage brokeredMessage = _queueHelper.Receive();

                if (brokeredMessage != null)
                {
                    try
                    {
                        QueueMessage message = JsonConvert.DeserializeObject<QueueMessage>(brokeredMessage.AsString);

                        HandleMessage(message);

                        _queueHelper.CompleteMessage(brokeredMessage);
                    }
                    catch (Exception)
                    {
                        _queueHelper.AbandonMessage(brokeredMessage);
                    }
                }
            }
        }

        private void HandleMessage(QueueMessage message)
        {
            switch (message.MessageType)
            {
                case QueueMessageType.SignIn:
                    HandleSignInMessage(message);
                    break;
            }
        }

        private void HandleSignInMessage(QueueMessage message)
        {
            using (EventsContext context = new EventsContext())
            {
                var eventItem = context.Events.SingleOrDefault(e => e.Id == message.EventId);

                IEnumerable<string> names = _tableHelper.GetRegistrantNames(eventItem.EventKey);

                using (MemoryStream stream = _documentGenerator.CreateSignInDocument(eventItem.Title, names))
                {
                    Uri documentUrl = _blobHelper.CreateBlob(stream, eventItem.EventKey);
                    eventItem.SignInDocumentUrl = documentUrl.AbsoluteUri;
                }

                context.SaveChanges();
            }
        }

        public override bool OnStart()
        {
            ServicePointManager.DefaultConnectionLimit = 12;

            return base.OnStart();
        }
    }
}