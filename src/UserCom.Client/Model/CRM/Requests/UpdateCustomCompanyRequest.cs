using System.Collections.Generic;

namespace UserCom.Model.CRM.Requests
{
    public class UpdateCustomCompanyRequest
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Email { get; set; }

        public string Country { get; set; }

        public string Region { get; set; }

        public string City { get; set; }

        public string? Address { get; set; }

        public int? ApproxEmployees { get; set; }

        public IEnumerable<string> PhoneNumbers { get; set; }

        public string CompanyId { get; set; }
    }
}