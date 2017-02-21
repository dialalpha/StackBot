using System.Runtime.Serialization;

namespace StackBot.Common.StackExchange
{
    [DataContract]
    public class Answer : Post
    {
        [DataMember(Name = "answer_id")]
        public override int Id { get; set; }

        [DataMember(Name = "is_accepted")]
        public bool IsAccepted { get; set; }

        [DataMember(Name = "question_id")]
        public ulong QuestionId { get; set; }
    }
}
