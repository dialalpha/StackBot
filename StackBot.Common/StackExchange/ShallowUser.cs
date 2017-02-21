using System.Runtime.Serialization;

namespace StackBot.Common.StackExchange
{
    [DataContract]
    public class ShallowUser
    {
        [DataMember(Name = "user_id")]
        public int Id { get; set; }

        [DataMember(Name = "display_name")]
        public string DisplayName { get; set; }

        [DataMember(Name = "reputation")]
        public int Reputation { get; set; }

        [DataMember(Name = "link")]
        public string Link { get; set; }

        [DataMember(Name = "profile_image")]
        public string ProfileImage { get; set; }
    }
}
