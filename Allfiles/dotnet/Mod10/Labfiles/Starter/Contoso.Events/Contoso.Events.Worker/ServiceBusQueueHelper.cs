using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using Microsoft.WindowsAzure;

namespace Contoso.Events.Worker
{
    /// TODO: Exercise 10.3: Retrieving Message from a Service Bus Queue 
    public sealed class ServiceBusQueueHelper : IQueueHelper<BrokeredMessage>
    {
        private readonly QueueClient _client;

        public ServiceBusQueueHelper()
        {
            string serviceBusConnectionString = CloudConfigurationManager.GetSetting("Microsoft.ServiceBus.ConnectionString");
            string signInQueueName = CloudConfigurationManager.GetSetting("SignInQueueName");
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