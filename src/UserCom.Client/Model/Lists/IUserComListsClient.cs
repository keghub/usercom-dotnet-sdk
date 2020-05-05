using System.Threading.Tasks;

namespace UserCom.Model.Lists
{
    public interface IUserComListsClient
    {
        Task<List> CreateAsync(string name, string description);

        Task UpdateAsync(int id, string? name = null, string? description = null);

        Task DeleteAsync(int id);

        Task<PaginatedResult<List>> GetAllAsync();
    }
}
