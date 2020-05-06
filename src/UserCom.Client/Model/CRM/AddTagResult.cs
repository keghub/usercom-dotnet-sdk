using Newtonsoft.Json;

namespace UserCom.Model.CRM
{
    public class AddTagResult
    {
        [JsonProperty("created")]
        public bool Created { get; set; }

        [JsonProperty("tag_name")]
        public string TagName { get; set; }
    }
}