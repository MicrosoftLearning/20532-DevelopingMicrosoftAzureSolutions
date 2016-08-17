using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Contoso.Events.Models
{
    public class Event
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string EventKey { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime StartTime { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime EndTime { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Range(0, Int16.MaxValue)]
        public short RegistrationCount { get; set; }
                
        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        [DataType(DataType.Url)]
        public string SignInDocumentUrl { get; set; }
    }
}