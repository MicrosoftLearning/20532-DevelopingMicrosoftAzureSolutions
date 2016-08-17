using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;

namespace Contoso.Events.Worker
{
    
    public class TableStorageQueueHelper : StorageHelper, IQueueHelper<CloudQueueMessage>
    {
        private readonly CloudQueueClient _queueClient;
        private readonly string _signInQueueName;

        public TableStorageQueueHelper()
            : base()
        {

        }

        public IQueueMessage<CloudQueueMessage> Receive()
        {            
            return new TableStorageQueueMessage(null);
        }

        public void CompleteMessage(CloudQueueMessage message)
        {

        }

        public void AbandonMessage(CloudQueueMessage message)
        {

        }
    }
}