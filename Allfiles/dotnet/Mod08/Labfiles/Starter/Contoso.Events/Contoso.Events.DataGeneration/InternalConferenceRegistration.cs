using Contoso.Events.Models;
using System;

namespace Contoso.Events.Data.Generation
{
    public class InternalConferenceRegistration : Registration
    {
        public InternalConferenceRegistration(Guid eventKey)
            : base(eventKey)
        { }

        public InternalConferenceRegistration(string partitionKey)
            : base(partitionKey)
        { }

        public InternalConferenceRegistration() { }

        public bool OnMainCampus { get; set; }

        public string Department { get; set; }

        public string EmployeeID { get; set; }
    }
}