using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace StackBot.Common.StackExchange
{
    [DataContract]
    [KnownType(typeof(Question))]
    public class Post
    {
        [DataMember(Name = "post_id")]
        public virtual int Id { get; set; }

        [DataMember(Name = "body")]
        public string Body { get; set; }

        [DataMember(Name = "owner")]
        public ShallowUser Owner { get; set; }

        [DataMember(Name = "creation_date")]
        internal long CreationDateInternal { get; set; }

        public DateTime CreationDate => UnixTimeConverter.ConvertFromUnixTime(CreationDateInternal);

        [DataMember(Name = "score")]
        public int Score { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "link")]
        public string Link { get; set; }

        [DataMember(Name = "tags")]
        public IList<string> Tags { get; set; }
    }
}
