using System.Collections.Generic;
using System.Threading.Tasks;
using UserCom.Model.CRM.Requests;

namespace UserCom.Model.CRM
{
    public interface IUserComCrmClient
    {
        Task<Company> CreateCompanyAsync(CreateCompanyRequest request);

        Task<Company> UpdateCompanyAsync(UpdateCompanyRequest request);

        Task DeleteCompanyAsync(int id);

        Task<Company> FindCompanyByIdAsync(int id);

        Task<PaginatedResult<Company>> GetAllCompaniesAsync();

        Task SetCompanyAttributeAsync(int id, (string attribute, object value) attribute);

        Task SetCompanyMultipleAttributesAsync(int id, Dictionary<string, object> attributes);

        Task<AddTagResult> AddCompanyTagAsync(int id, string name);

        Task RemoveCompanyTagAsync(int id, string name);
    }
}