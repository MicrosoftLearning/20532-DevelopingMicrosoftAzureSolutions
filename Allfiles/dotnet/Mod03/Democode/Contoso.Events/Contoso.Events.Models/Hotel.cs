using System.Runtime.Serialization;

namespace Contoso.Events.Models
{
    [DataContract]
    public class Hotel
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }

        [DataMember]
        public string Website { get; set; }

        [DataMember]
        public double Latitude { get; set; }

        [DataMember]
        public double Longitude { get; set; }

        [DataMember]
        public string Address { get; set; }
    }
}