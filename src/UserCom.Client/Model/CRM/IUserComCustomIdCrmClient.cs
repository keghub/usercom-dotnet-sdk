using System.Collections.Generic;
using System.Threading.Tasks;
using UserCom.Model.CRM.Requests;

namespace UserCom.Model.CRM
{
    public interface IUserComCustomIdCrmClient
    {
        Task<Company> UpdateCompanyAsync(UpdateCompanyRequest request);

        Task DeleteCompanyAsync(string companyId);

        Task<Company> FindCompanyByIdAsync(string companyId);

        Task SetCompanyAttributeAsync(string companyId, (string attribute, object value) attribute);

        Task SetCompanyMultipleAttributesAsync(string companyId, Dictionary<string, object> attributes);

        Task<AddTagResult> AddCompanyTagAsync(string companyId, string name);

        Task RemoveCompanyTagAsync(string companyId, string name);
    }
}
