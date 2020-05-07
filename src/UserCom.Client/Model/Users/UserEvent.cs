using Newtonsoft.Json;
using UserCom.Model.Events;

namespace UserCom.Model.Users
{
    public class UserEvent : Event
    {
        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("event_id")]
        public int EventId { get; set; }
    }
}