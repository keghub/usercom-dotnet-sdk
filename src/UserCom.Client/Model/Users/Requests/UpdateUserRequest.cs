using Newtonsoft.Json;

namespace UserCom.Model.Users.Requests
{
    public class UpdateUserRequest : UpdateOrCreateUserRequest
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}