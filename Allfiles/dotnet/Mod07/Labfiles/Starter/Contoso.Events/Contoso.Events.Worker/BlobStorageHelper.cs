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

        /// TODO: Exercise 09.2: Populating the Container with Files and Media
        public Uri CreateBlob(MemoryStream stream, string eventKey)
        {
            return null;
        }
    }
}