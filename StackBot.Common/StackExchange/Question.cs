using System.Runtime.Serialization;

namespace StackBot.Common.StackExchange
{
    [DataContract]
    public class Question : Post
    {
        [DataMember(Name = "question_id")]
        public override int Id { get; set; }

        [DataMember(Name = "is_answered")]
        public bool IsAnswered { get; set; }
    }
}
