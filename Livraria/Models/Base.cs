using System.Runtime.Serialization;

namespace Livraria.Models
{
    [DataContract]
    public class Base
    {
        [DataMember]
        public int Id { get; protected set; }
    }
}
