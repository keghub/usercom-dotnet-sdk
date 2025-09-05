using Newtonsoft.Json;
using UserCom.Serialization;

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

        [JsonProperty("value"), JsonConverter(typeof(AttributeValueConverter))]
        public string Value { get; set; }
    }
}