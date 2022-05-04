using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserCom.Model.Users.Requests
{
    public class AddEventRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("data")]
        public object MemberDataJson { get; set; }
    }
}
