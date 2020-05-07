using System;
using Newtonsoft.Json;

namespace UserCom.Model.Users
{
    public class UserEmail
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("sent_at")]
        public DateTime? SentAt { get; set; }

        [JsonProperty("opened_at")]
        public DateTime? OpenedAt { get; set; }

        [JsonProperty("clicked_at")]
        public DateTime? ClickedAt { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }
    }
}