using Contoso.Events.Models;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System.Configuration;
using System.IO;
using System.Threading.Tasks;

namespace Contoso.Events.ViewModels
{
    public class DownloadViewModel
    {
        private readonly string _blobId;

        public DownloadViewModel(string blobId)
        {
            _blobId = blobId;
        }

        /// TODO: Exercise 09.3: Retrieving Files and Media from the Container 
        /// TODO: Exercise 09.4: Specifying Permissions for the Container 
        public async Task<DownloadPayload> GetStream()
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(ConfigurationManager.AppSettings["Microsoft.WindowsAzure.Storage.ConnectionString"]);
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer container = blobClient.GetContainerReference("signin");

            ICloudBlob blob = container.GetBlockBlobReference(_blobId);

            Stream blobStream = await blob.OpenReadAsync();

            return new DownloadPayload { Stream = blobStream, ContentType = blob.Properties.ContentType };
        }
    }
}