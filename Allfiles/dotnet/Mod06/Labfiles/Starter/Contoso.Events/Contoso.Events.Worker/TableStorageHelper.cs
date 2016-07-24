﻿using Contoso.Events.Models;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Contoso.Events.Worker
{
    public sealed class TableStorageHelper : StorageHelper
    {
        private readonly CloudTableClient _tableClient;

        public TableStorageHelper()
            : base()
        {
            _tableClient = base.StorageAccount.CreateCloudTableClient();
        }

        /// TODO: Exercise 08.2: Populating the Sign-In Form with Registrant Names
        public IEnumerable<string> GetRegistrantNames(string eventKey)
        {
            return Enumerable.Empty<string>();
        }
    }
}