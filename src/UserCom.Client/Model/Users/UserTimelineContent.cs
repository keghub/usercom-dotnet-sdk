using Newtonsoft.Json;

namespace UserCom.Model.Users
{
    public class UserTimelineContent
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}