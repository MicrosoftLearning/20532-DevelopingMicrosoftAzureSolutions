using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;

namespace Contoso.Events.Worker
{
    /// TODO: Exercise 10.2: Retrieving Messages from Azure Queue Storage 
    public class TableStorageQueueHelper : StorageHelper, IQueueHelper<CloudQueueMessage>
    {
        private readonly CloudQueueClient _queueClient;
        private readonly string _signInQueueName;

        public TableStorageQueueHelper()
            : base()
        {
            CloudStorageAccount storageAccount = base.StorageAccount;
            _queueClient = storageAccount.CreateCloudQueueClient();
            _signInQueueName = CloudConfigurationManager.GetSetting("SignInQueueName");
        }

        public IQueueMessage<CloudQueueMessage> Receive()
        {
            CloudQueue queue = _queueClient.GetQueueReference(_signInQueueName);
            queue.CreateIfNotExists();

            CloudQueueMessage message = queue.GetMessage();
            return new TableStorageQueueMessage(message);
        }

        public void CompleteMessage(CloudQueueMessage message)
        {
            CloudQueue queue = _queueClient.GetQueueReference(_signInQueueName);
            queue.CreateIfNotExists();

            queue.DeleteMessage(message);
        }

        public void AbandonMessage(CloudQueueMessage message)
        {

        }
    }
}