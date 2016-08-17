using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.IO;

namespace Contoso.Events.Worker
{
    public sealed class BlobStorageHelper : StorageHelper
    {
        private readonly CloudBlobClient _blobClient;

        public BlobStorageHelper()
            : base()
        {
            _blobClient = base.StorageAccount.CreateCloudBlobClient();
        }

        
        public Uri CreateBlob(MemoryStream stream, string eventKey)
        {
            CloudBlobContainer container = _blobClient.GetContainerReference("signin");

            string blobName = String.Format("{0}_SignIn_{1:ddmmyyyss}.docx", eventKey, DateTime.UtcNow);

            ICloudBlob blob = container.GetBlockBlobReference(blobName);
            stream.Seek(0, SeekOrigin.Begin);
            blob.UploadFromStream(stream);

            return blob.Uri;
        }
    }
}