using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contoso.Events.Models
{
    public class SignInDocument
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string EventKey { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? TimeStamp { get; set; }

        [DataType(DataType.Upload)]
        public byte[] Document { get; set; }
        
        public bool Generated { get; set; }

        [ForeignKey("EventKey")]
        public virtual Event Event { get; set; }
    }
}
