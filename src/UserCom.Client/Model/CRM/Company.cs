using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UserCom.Model.Attributes;

namespace UserCom.Model.CRM
{
    public class Company
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country")]
        public string Region { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("address")]
        public string? Address { get; set; }

        [JsonProperty("approx_employees")]
        public int? ApproxEmployees { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("phone_numbers")]
        public IReadOnlyList<string> PhoneNumbers { get; set; }

        [JsonProperty("attributes")]
        public IReadOnlyList<AttributeValue> Attributes { get; set; }

        [JsonProperty("company_id")]
        public string? CompanyId { get; set; }
    }
}