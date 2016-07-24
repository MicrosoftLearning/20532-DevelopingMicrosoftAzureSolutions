using System;
using System.Runtime.Serialization;

namespace Contoso.Events.Models
{
    [DataContract]
    public class QueueMessage
    {
        [DataMember]
        public int EventId { get; set; }

        [DataMember]
        public QueueMessageType MessageType { get; set; }
    }

    [DataContract]
    public enum QueueMessageType
    {
        [EnumMember]
        Unknown = 0,

        [EnumMember]
        SignIn
    }
}