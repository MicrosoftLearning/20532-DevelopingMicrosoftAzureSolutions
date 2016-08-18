using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using System.Configuration;

namespace Contoso.Events.Worker
{
    public abstract class StorageHelper
    {
        protected readonly CloudStorageAccount StorageAccount;

        public StorageHelper()
        {
            this.StorageAccount = CloudStorageAccount.Parse(ConfigurationManager.AppSettings["StorageConnectionString"]);
        }
    }
}
