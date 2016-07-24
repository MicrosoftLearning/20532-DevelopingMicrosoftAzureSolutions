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

        }

        public IQueueMessage<BrokeredMessage> Receive()
        {
            return new ServiceBusQueueMessage(null);
        }

        public void CompleteMessage(BrokeredMessage message)
        {

        }

        public void AbandonMessage(BrokeredMessage message)
        {

        }
    }
}