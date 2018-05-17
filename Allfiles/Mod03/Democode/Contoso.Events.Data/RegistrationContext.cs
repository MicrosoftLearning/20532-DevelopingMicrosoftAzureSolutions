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
        protected Database Database { get; set; }

        protected DocumentCollection Collection { get; set; }

        protected DocumentClient Client { get; set; }

        protected CosmosSettings CosmosSettings { get; set; }

        public RegistrationContext(IOptions<CosmosSettings> cosmosSettings)
        {
            CosmosSettings = cosmosSettings.Value;
            Client = new DocumentClient(new Uri(CosmosSettings.EndpointUrl), CosmosSettings.AuthorizationKey);
        }

        public async Task ConfigureConnectionAsync()
        { 
            Database = await Client.CreateDatabaseIfNotExistsAsync(new Database { Id = CosmosSettings.DatabaseId });
            Collection = await Client.CreateDocumentCollectionIfNotExistsAsync(Database.SelfLink, new DocumentCollection { Id = CosmosSettings.CollectionId });
        }

        public async Task<int> GetRegistrantCountAsync()
        {
            FeedOptions options = new FeedOptions { EnableCrossPartitionQuery = true };
            IDocumentQuery<int> query = Client.CreateDocumentQuery<int>(Collection.SelfLink, "SELECT VALUE COUNT(1) FROM registrants", options).AsDocumentQuery();

            int count = 0;
            while (query.HasMoreResults)
            {
                FeedResponse<int> results = await query.ExecuteNextAsync<int>();
                count += results.Sum();
            }
            return count;
        }

        public async Task<List<string>> GetRegistrantsForEvent(string eventKey)
        {
            IDocumentQuery<GeneralRegistration> query = Client.CreateDocumentQuery<GeneralRegistration>(Collection.SelfLink).Where(r => r.EventKey == eventKey).AsDocumentQuery();

            List<string> registrants = new List<string>();
            while (query.HasMoreResults)
            {
                FeedResponse<GeneralRegistration> results = await query.ExecuteNextAsync<GeneralRegistration>();
                IEnumerable<string> resultNames = results.Select(r => $"{r.FirstName} {r.LastName}");
                registrants.AddRange(resultNames);
            }
            return registrants;
        }

        public async Task<string> UploadEventRegistrationAsync(dynamic registration)
        {
            ResourceResponse<Document> response = await Client.CreateDocumentAsync(Collection.SelfLink, registration);
            return response.Resource.Id;
        }
    }
}