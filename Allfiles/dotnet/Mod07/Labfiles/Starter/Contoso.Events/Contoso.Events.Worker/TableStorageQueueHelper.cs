using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage.Queue;

namespace Contoso.Events.Worker
{
    
    public class TableStorageQueueHelper : StorageHelper, IQueueHelper<CloudQueueMessage>
    {
        private readonly CloudQueueClient _queueClient;

        public TableStorageQueueHelper()
            : base()
        {
            _queueClient = base.StorageAccount.CreateCloudQueueClient();
        }

        public CloudQueueMessage Receive()
        {
            CloudQueue queue = GetCloudQueue();

            return queue.GetMessage();
        }
        public void CompleteMessage(CloudQueueMessage message)
        {
            CloudQueue queue = GetCloudQueue();

            queue.DeleteMessage(message);
        }

        public void AbandonMessage(CloudQueueMessage message)
        {

        }

        private CloudQueue GetCloudQueue()
        {
            string signInQueueName = CloudConfigurationManager.GetSetting("SignInQueueName");
            CloudQueue queue = _queueClient.GetQueueReference(signInQueueName);
            queue.CreateIfNotExists();
            return queue;
        }
    }
}