using Contoso.Events.Models;
using Microsoft.Extensions.Options;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Contoso.Events.Data
{
    public class BlobContext
    {
        protected StorageSettings StorageSettings;

        public BlobContext(IOptions<StorageSettings> cosmosSettings)
        {
            StorageSettings = cosmosSettings.Value;
        }

        public async Task<ICloudBlob> UploadBlobAsync(string blobName, Stream stream)
        {
            return await Task.FromResult(default(ICloudBlob));
        }

        public async Task<DownloadPayload> GetStreamAsync(string blobId)
        {
            return await Task.FromResult(default(DownloadPayload));
        }

        public async Task<string> GetSecureUrlAsync(string blobId)
        {
            return await Task.FromResult(default(string));
        }
    }
}