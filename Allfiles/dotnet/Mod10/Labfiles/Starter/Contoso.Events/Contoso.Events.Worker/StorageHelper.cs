using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;

namespace Contoso.Events.Worker
{
    public abstract class StorageHelper
    {
        protected readonly CloudStorageAccount StorageAccount;

        public StorageHelper()
        {
            this.StorageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("Microsoft.WindowsAzure.Storage.ConnectionString"));
        }
    }
}