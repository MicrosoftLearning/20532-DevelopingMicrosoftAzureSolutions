using Contoso.Events.Models;
using System;

namespace Contoso.Events.Data.Generation
{
    public class SalesConferenceRegistration : Registration
    {
        public SalesConferenceRegistration(Guid eventKey)
            : base(eventKey)
        { }

        public SalesConferenceRegistration(string partitionKey)
            : base(partitionKey)
        { }

        public SalesConferenceRegistration() { }

        public string Region { get; set; }

        public int AnnualSales { get; set; }
    }
}