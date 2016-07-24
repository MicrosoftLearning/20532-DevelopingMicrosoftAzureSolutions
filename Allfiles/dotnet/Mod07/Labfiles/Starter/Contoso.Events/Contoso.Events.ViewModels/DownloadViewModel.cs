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

        /// TODO: Exercise 09.3: Retrieving Files and Media from the Container 
        public async Task<DownloadPayload> GetStream()
        {
            return await Task.FromResult<DownloadPayload>(null);
        }

        /// TODO: Exercise 09.4: Specifying Permissions for the Container 
        public async Task<string> GetSecureUrl()
        {
            return await Task.FromResult<string>(String.Empty);
        }
    }
}