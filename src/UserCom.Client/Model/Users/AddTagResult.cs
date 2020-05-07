using Newtonsoft.Json;

namespace UserCom.Model.Users
{
    public class AddTagResult
    {
        [JsonProperty("created")]
        public bool Created { get; set; }

        [JsonProperty("tag_name")]
        public string TagName { get; set; }
    }
}