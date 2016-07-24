using Contoso.Events.Models;
using Microsoft.ServiceBus.Messaging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Events.Worker
{
    public class ServiceBusQueueMessage : IQueueMessage<BrokeredMessage>
    {
        public ServiceBusQueueMessage(BrokeredMessage message)
        {
            this.SourceMessage = message;
        }

        public BrokeredMessage SourceMessage { get; private set; }

        public QueueMessage GetMessage()
        {
            return this.SourceMessage.GetBody<QueueMessage>();
        }
    }
}