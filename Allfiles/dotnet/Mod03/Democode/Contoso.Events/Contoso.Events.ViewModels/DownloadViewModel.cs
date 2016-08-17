using Contoso.Events.Models;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Configuration;
using System.IO;
using System.Threading.Tasks;

namespace Contoso.Events.ViewModels
{
    public class DownloadViewModel
    {
        private readonly CloudStorageAccount _storageAccount = CloudStorageAccount.Parse(ConfigurationManager.AppSettings["Microsoft.WindowsAzure.Storage.ConnectionString"]);
        private readonly string _blobId;

        public DownloadViewModel(string blobId)
        {
            _blobId = blobId;
        }
        public async Task<DownloadPayload> GetStream()
        {
            CloudBlobClient blobClient = _storageAccount.CreateCloudBlobClient();
            CloudBlobContainer container = blobClient.GetContainerReference("signin");
            await container.CreateIfNotExistsAsync();

            ICloudBlob blob = container.GetBlockBlobReference(_blobId);
            Stream blobStream = await blob.OpenReadAsync();

            return new DownloadPayload { Stream = blobStream, ContentType = blob.Properties.ContentType };
        }
        public async Task<string> GetSecureUrl()
        {
            CloudBlobClient blobClient = _storageAccount.CreateCloudBlobClient();
            CloudBlobContainer container = blobClient.GetContainerReference("signin");
            await container.CreateIfNotExistsAsync();

            SharedAccessBlobPolicy blobPolicy = new SharedAccessBlobPolicy();
            blobPolicy.SharedAccessExpiryTime = DateTime.Now.AddHours(0.25d);
            blobPolicy.Permissions = SharedAccessBlobPermissions.Read;

            BlobContainerPermissions blobPermissions = new BlobContainerPermissions();
            blobPermissions.SharedAccessPolicies.Add("ReadBlobPolicy", blobPolicy);
            blobPermissions.PublicAccess = BlobContainerPublicAccessType.Off;

            await container.SetPermissionsAsync(blobPermissions);
            string sasToken = container.GetSharedAccessSignature(new SharedAccessBlobPolicy(), "ReadBlobPolicy");

            ICloudBlob blob = container.GetBlockBlobReference(_blobId);
            Uri blobUrl = blob.Uri;

            return blobUrl.AbsoluteUri + sasToken;
        }
    }
}