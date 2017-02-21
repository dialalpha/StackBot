using System.Runtime.Serialization;

namespace StackBot.Common
{
    [DataContract]
    public class SearchRequest
    {
        [DataMember]
        public string Query { get; set; }
    }
}
