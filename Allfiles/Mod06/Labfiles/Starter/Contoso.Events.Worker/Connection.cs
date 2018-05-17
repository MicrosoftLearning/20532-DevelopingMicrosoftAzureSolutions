using Contoso.Events.Data;
using Contoso.Events.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;

namespace Contoso.Events.Worker
{
    public class ConnectionManager
    {
        public EventsContext GetSqlContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<EventsContext>();
            optionsBuilder.UseSqlServer(GetEnvironmentVariable("EventsContextConnectionString"));
            return new EventsContext(optionsBuilder.Options);
        }

        public RegistrationContext GetCosmosContext()
        {
            var options = new CosmosSettings
            {
                EndpointUrl = GetEnvironmentVariable("CosmosEndpointUrl"),
                AuthorizationKey = GetEnvironmentVariable("CosmosAuthorizationKey"),
                DatabaseId = GetEnvironmentVariable("CosmosDatabaseId"),
                CollectionId = GetEnvironmentVariable("CosmosCollectionId")
            };
            return new RegistrationContext(Options.Create<CosmosSettings>(options));
        }

        private string GetEnvironmentVariable(string name)
        {
            return Environment.GetEnvironmentVariable(name, EnvironmentVariableTarget.Process);
        }
    }
}