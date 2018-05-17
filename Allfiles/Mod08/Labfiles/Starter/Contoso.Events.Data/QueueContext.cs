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

        public QueueContext(IOptions<StorageSettings> storageSettings)
        {
            StorageSettings = storageSettings.Value;
        }

        public async Task SendQueueMessageAsync(string eventKey)
        {
            await Task.FromResult<object>(null);
        }
    }
}