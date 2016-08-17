using Contoso.Events.Data;
using Contoso.Events.Models;
using Contoso.Events.ViewModels.Dynamic;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Contoso.Events.ViewModels
{
    public class RegisterViewModel
    {
        public RegisterViewModel()
        { }

        public RegisterViewModel(string eventKey)
        {
            using (EventsContext context = new EventsContext())
            {
                this.Event = context.Events.SingleOrDefault(e => e.EventKey == eventKey);
            }

            string connectionString = CloudConfigurationManager.GetSetting("Microsoft.WindowsAzure.Storage.ConnectionString");
            var storageAccount = Microsoft.WindowsAzure.Storage.CloudStorageAccount.Parse(connectionString);

            var tableClient = storageAccount.CreateCloudTableClient();
            var table = tableClient.GetTableReference("EventRegistrations");
            
            string partitionKey = String.Format("Stub_{0}", this.Event.EventKey);
            string filter = TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, partitionKey);

            TableQuery query = new TableQuery().Where(filter);
            IEnumerable<DynamicTableEntity> tableEntities = table.ExecuteQuery(query);

            DynamicTableEntity tableEntity = tableEntities.SingleOrDefault();
            this.RegistrationStub = DynamicEntity.GenerateDynamicItem(tableEntity);
        }

        public Event Event { get; set; }

        public Registration RegistrationStub { get; set; }
    }
}