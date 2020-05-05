using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UserCom.Model.CRM;
using UserCom.Model.CRM.Requests;

namespace UserCom
{
    public partial class UserComClient : IUserComCustomIdCrmClient
    {
        private static string CUSTOMIDCOMPANY_RESOURCE = "/api/public/companies-by-id";

        public async Task<AddTagResult> AddCompanyTagAsync(string companyId, string name)
        {
            var response = await SendAsync<dynamic, dynamic>(HttpMethod.Post, $"{CUSTOMIDCOMPANY_RESOURCE}/{companyId}/add_tag", new { name });
            var result = new AddTagResult
            {
                Created = response.created,
                TagName = response.tag.name
            };

            return result;
        }

        public async Task DeleteCompanyAsync(string companyId)
        {
            await SendAsync(HttpMethod.Delete, $"{CUSTOMIDCOMPANY_RESOURCE}/{companyId}");
        }

        public async Task<Company> FindCompanyByIdAsync(string companyId)
        {
            var result = await SendAsync<Company>(HttpMethod.Get, $"{CUSTOMIDCOMPANY_RESOURCE}/{companyId}/");

            return result;
        }

        public async Task RemoveCompanyTagAsync(string companyId, string name)
        {
            await SendAsync(HttpMethod.Delete, $"{CUSTOMIDCOMPANY_RESOURCE}/{companyId}/remove_tag/", new { name });
        }

        public async Task SetCompanyAttributeAsync(string companyId, (string attribute, object value) attribute)
        {
            await SendAsync<dynamic>(HttpMethod.Post, $"{CUSTOMIDCOMPANY_RESOURCE}/{companyId}/set_attribute/", attribute);
        }

        public async Task SetCompanyMultipleAttributesAsync(string companyId, Dictionary<string, object> attributes)
        {
            await SendAsync(HttpMethod.Post, $"{CUSTOMIDCOMPANY_RESOURCE}/{companyId}/set_multiple_attributes", attributes);
        }

        public async Task<Company> UpdateCompanyAsync(UpdateCompanyRequest request)
        {
            var result = await SendAsync<Company>(HttpMethod.Put, $"{CUSTOMIDCOMPANY_RESOURCE}/{request.CompanyId}");

            return result;
        }
    }
}
