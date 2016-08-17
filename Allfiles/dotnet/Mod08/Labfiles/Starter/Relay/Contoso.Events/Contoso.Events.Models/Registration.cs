using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.ComponentModel.DataAnnotations;

namespace Contoso.Events.Models
{
    [MetadataType(typeof(RegistrationMetadata))]
    public class Registration : TableEntity
    {
        public Registration(Guid eventKey)
            : this(eventKey.ToString())
        { }

        public Registration(string partitionKey)
        {
            this.PartitionKey = partitionKey;
            this.RowKey = Guid.NewGuid().ToString();
        }

        public Registration() { }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsStub { get; set; }
    }

    public class RegistrationMetadata
    {
        [Display(Prompt = "First Name")]
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Display(Prompt = "Last Name")]
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }


        [ScaffoldColumn(false)]
        public bool IsStub { get; set; }

        [ScaffoldColumn(false)]
        public string RowKey { get; set; }

        [ScaffoldColumn(false)]
        public string PartitionKey { get; set; }

        [ScaffoldColumn(false)]
        public string ETag { get; set; }

        [ScaffoldColumn(false)]
        public DateTimeOffset Timestamp { get; set; }
    }
}