using System;
using System.Collections.Generic;
using UserCom.Model.Attributes;

namespace UserCom.Model.CRM
{
    public class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Email { get; set; }

        public string Country { get; set; }

        public string Region { get; set; }

        public string City { get; set; }

        public string? Address { get; set; }

        public int? ApproxEmployees { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public IReadOnlyList<string> PhoneNumbers { get; set; }

        public IReadOnlyList<AttributeValue> Attributes { get; set; }

        public int? CompanyId { get; set; }
    }
}