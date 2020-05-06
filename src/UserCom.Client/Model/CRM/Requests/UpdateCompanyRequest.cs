using Newtonsoft.Json;

namespace UserCom.Model.CRM.Requests
{
    public class UpdateCompanyRequest : CreateCompanyRequest
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}