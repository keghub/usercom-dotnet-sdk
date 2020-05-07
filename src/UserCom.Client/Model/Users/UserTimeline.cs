using System;
using Newtonsoft.Json;

namespace UserCom.Model.Users
{
    public class UserTimeline
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("datetime")]
        public DateTime Datetime { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("content")]
        public UserTimelineContent Content { get; set; }
    }
}