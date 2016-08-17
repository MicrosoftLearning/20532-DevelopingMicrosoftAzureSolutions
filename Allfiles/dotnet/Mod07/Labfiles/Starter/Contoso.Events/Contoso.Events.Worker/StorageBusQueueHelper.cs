using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using Microsoft.Azure;
using System.Configuration;

namespace Contoso.Events.Worker
{
    
    public sealed class StorageBusQueueHelper : IQueueHelper<BrokeredMessage>
    {
        private readonly QueueClient _client;

        public StorageBusQueueHelper()
        {
            string serviceBusConnectionString = ConfigurationManager.AppSettings["Microsoft.ServiceBus.ConnectionString"];
            string signInQueueName = ConfigurationManager.AppSettings["SignInQueueName"];
            NamespaceManager namespaceManager = NamespaceManager.CreateFromConnectionString(serviceBusConnectionString);

            _client = QueueClient.CreateFromConnectionString(serviceBusConnectionString, signInQueueName);
        }

        public BrokeredMessage Receive()
        {
            return _client.Receive();
        }

        public void CompleteMessage(BrokeredMessage message)
        {
            message.Complete();
        }

        public void AbandonMessage(BrokeredMessage message)
        {
            message.Abandon();
        }
    }
}