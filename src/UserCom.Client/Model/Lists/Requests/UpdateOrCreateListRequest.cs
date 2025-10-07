using Newtonsoft.Json;

namespace UserCom.Model.Lists.Requests
{
    public class UpdateOrCreateListRequest
    {
        [JsonProperty("name")]
        public string? Name { get; set; }
        
        [JsonProperty("description")]
        public string? Description { get; set; }
    }
}