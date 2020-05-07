using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace UserCom.Model.Events
{
    public class Event
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("client")]
        public int Client { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("items")]
        public IReadOnlyList<KeyValuePair<string, string>> Items { get; set; }
    }
}