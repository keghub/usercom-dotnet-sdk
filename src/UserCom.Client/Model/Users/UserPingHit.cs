using System;
using Newtonsoft.Json;

namespace UserCom.Model.Users
{
    public class UserPingHit
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("client")]
        public int Client { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }

        [JsonProperty("browser_family")]
        public string BrowserFamily { get; set; }

        [JsonProperty("browser_version")]
        public string BrowserVersion { get; set; }

        [JsonProperty("os_type")]
        public string OsType { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("referer")]
        public string Referer { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("extra_data")]
        public string ExtraData { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("resolution")]
        public string Resolution { get; set; }
    }
}