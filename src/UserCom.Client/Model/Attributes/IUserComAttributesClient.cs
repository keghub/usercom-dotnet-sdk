using System.Threading.Tasks;

namespace UserCom.Model.Attributes
{
    public interface IUserComAttributesClient
    {
        Task<Attribute> CreateAsync(ValueType valueType, string name, CreationContentType contentType);

        Task DeleteAsync(int id);

        Task<Attribute> FindByIdAsync(int id);

        Task<PaginatedResult<Attribute>> GetAllAsync();

        Task<ValueType> GetUserValueTypeAsync(string urlFriendlyName);

        Task<ValueType> GetCompanyValueTypeAsync(string urlFriendlyName);
    }
}
