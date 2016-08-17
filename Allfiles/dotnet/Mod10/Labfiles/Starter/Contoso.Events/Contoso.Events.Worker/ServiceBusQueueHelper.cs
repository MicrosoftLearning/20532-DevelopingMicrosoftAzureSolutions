using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using Microsoft.Azure;
using System.Configuration;

namespace Contoso.Events.Worker
{
    public sealed class ServiceBusQueueHelper : IQueueHelper<BrokeredMessage>
    {
        private readonly QueueClient _client;

        public ServiceBusQueueHelper()
        {
            string serviceBusConnectionString = ConfigurationManager.AppSettings["Microsoft.ServiceBus.ConnectionString"];
            string signInQueueName = ConfigurationManager.AppSettings["SignInQueueName"];
            _client = QueueClient.CreateFromConnectionString(serviceBusConnectionString, signInQueueName);
        }

        public IQueueMessage<BrokeredMessage> Receive()
        {
            BrokeredMessage message = _client.Receive();
            return new ServiceBusQueueMessage(message);
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