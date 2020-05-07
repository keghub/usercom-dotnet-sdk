using System;
using Newtonsoft.Json;
using UserCom.Model.Users;

namespace UserCom.Model.Segments
{
    public class Segment
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("users")]
        public Lazy<PaginatedResult<User>> Users { get; set; }
    }
}