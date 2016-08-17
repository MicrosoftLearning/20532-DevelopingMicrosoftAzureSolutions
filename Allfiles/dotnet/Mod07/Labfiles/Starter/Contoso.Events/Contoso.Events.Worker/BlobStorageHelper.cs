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
            return null;
        }
    }
}