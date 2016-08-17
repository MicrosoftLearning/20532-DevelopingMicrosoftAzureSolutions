using Contoso.Events.Models;
using System;

namespace Contoso.Events.Data.Generation
{
    public class TechnicalConferenceRegistration : Registration
    {
        public TechnicalConferenceRegistration(Guid eventKey)
            : base(eventKey)
        { }

        public TechnicalConferenceRegistration(string partitionKey)
            : base(partitionKey)
        { }

        public TechnicalConferenceRegistration() { }

        public int NumberOfKeyFobs { get; set; }
    }
}