using Contoso.Events.Models;
using Microsoft.WindowsAzure.Storage.Queue;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Events.Worker
{
    public class TableStorageQueueMessage : IQueueMessage<CloudQueueMessage>
    {
        public TableStorageQueueMessage(CloudQueueMessage message)
        {
            this.SourceMessage = message;
        }

        public CloudQueueMessage SourceMessage { get; private set; }

        public QueueMessage GetMessage()
        {
            return JsonConvert.DeserializeObject<QueueMessage>(this.SourceMessage.AsString);
        }
    }
}