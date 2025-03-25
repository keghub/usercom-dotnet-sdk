using System.Threading.Tasks;
using UserCom.Model.Users;

namespace UserCom.Model.Segments
{
    public interface IUserComUserSegmentClient
    {
        Task<PaginatedResult<User>> GetAllUsersInUserSegmentAsync(string segmentId);
    }
}
