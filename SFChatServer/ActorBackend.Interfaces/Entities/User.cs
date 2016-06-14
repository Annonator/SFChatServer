using System.Runtime.Serialization;

namespace ActorBackend.Interfaces.Entities
{
    [DataContract]
    public class User
    {
        [DataMember]
        public string Name { get; set; }
    }
}