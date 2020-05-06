using System;
using Newtonsoft.Json;

namespace UserCom.Model.Users
{
    public class UserCompany
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("member_since")]
        public DateTime MemberSince { get; set; }
    }
}