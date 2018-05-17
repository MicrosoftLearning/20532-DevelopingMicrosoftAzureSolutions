using Contoso.Events.Models;
using Microsoft.Extensions.Options;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using System.Threading.Tasks;

namespace Contoso.Events.Data
{
    public class QueueContext : IQueueContext
    {
        protected StorageSettings StorageSettings;

        public QueueContext(IOptions<StorageSettings> cosmosSettings)
        {
            StorageSettings = cosmosSettings.Value;
        }

        public async Task SendQueueMessageAsync(string eventKey)
        {
            CloudStorageAccount account = CloudStorageAccount.Parse(StorageSettings.ConnectionString);
            CloudQueueClient queueClient = account.CreateCloudQueueClient();
            CloudQueue queue = queueClient.GetQueueReference(StorageSettings.QueueName);
            await queue.CreateIfNotExistsAsync();

            CloudQueueMessage message = new CloudQueueMessage(eventKey);
            await queue.AddMessageAsync(message);
        }
    }
}