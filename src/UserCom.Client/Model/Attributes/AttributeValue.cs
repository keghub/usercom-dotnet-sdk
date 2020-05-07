using Newtonsoft.Json;

namespace UserCom.Model.Attributes
{
    public class AttributeValue
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name_std")]
        public string NameStd { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}