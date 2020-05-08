using Newtonsoft.Json;

namespace UserCom.Model.Attributes
{
    public class Attribute
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("content_type")]
        public ContentType ContentType { get; set; }

        [JsonProperty("name_std")]
        public string UrlFriendlyName { get; set; }

        [JsonProperty("value_type")]
        public ValueType ValueType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}