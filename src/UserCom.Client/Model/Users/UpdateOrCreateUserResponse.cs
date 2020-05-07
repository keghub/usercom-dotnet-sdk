using Newtonsoft.Json;

namespace UserCom.Model.Users
{
    public class UpdateOrCreateUserResponse
    {
        [JsonProperty("created")]
        public bool Created { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}