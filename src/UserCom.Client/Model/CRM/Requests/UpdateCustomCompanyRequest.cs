using System.Collections.Generic;
using Newtonsoft.Json;

namespace UserCom.Model.CRM.Requests
{
    public class UpdateCustomCompanyRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("address")]
        public string? Address { get; set; }

        [JsonProperty("approx_employees")]
        public int? ApproxEmployees { get; set; }

        [JsonProperty("phone_numbers")]
        public IEnumerable<string> PhoneNumbers { get; set; }

        [JsonProperty("company_id")]
        public string CompanyId { get; set; }
    }
}