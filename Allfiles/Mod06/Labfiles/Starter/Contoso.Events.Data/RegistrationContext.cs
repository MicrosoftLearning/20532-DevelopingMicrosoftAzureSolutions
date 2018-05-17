using Contoso.Events.Models;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.Documents.Linq;

namespace Contoso.Events.Data
{
    public class RegistrationContext
    {
        protected CosmosSettings CosmosSettings { get; set; }

        public RegistrationContext(IOptions<CosmosSettings> cosmosSettings)
        {
            CosmosSettings = cosmosSettings.Value;
        }

        public async Task ConfigureConnectionAsync()
        {
            await Task.FromResult(default(object));
        }

        public async Task<int> GetRegistrantCountAsync()
        {
            return await Task.FromResult(default(int));
        }

        public async Task<List<string>> GetRegistrantsForEvent(string eventKey)
        {
            return await Task.FromResult(default(List<string>));
        }

        public async Task<string> UploadEventRegistrationAsync(dynamic registration)
        {
            return await Task.FromResult(default(string));
        }
    }
}