using System.Threading.Tasks;
using UserCom.Model.CRM;
using UserCom.Model.Users;

namespace UserCom.Model.Tags
{
    public interface IUserComTagsClient
    {
        Task<Tag> CreateAsync(string name);

        Task UpdateAsync(int id, string name);

        Task DeleteAsync(int id);

        Task<PaginatedResult<Tag>> GetAllAsync();

        Task<PaginatedResult<User>> FindUsersAsync(int id);

        Task<PaginatedResult<Company>> FindCompaniesAsync(int id);
    }
}
