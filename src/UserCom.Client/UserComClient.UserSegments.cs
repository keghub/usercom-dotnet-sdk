using System.Net.Http;
using System.Threading.Tasks;
using UserCom.Model;
using UserCom.Model.Segments;
using UserCom.Model.Users;

namespace UserCom
{
    public partial class UserComClient : IUserComUserSegmentClient
    {
        private static string SEGMENTS_RESOURCE = "/api/public/segments";

        async Task<PaginatedResult<User>> IUserComUserSegmentClient.GetAllUsersInUserSegmentAsync(string segmentId)
        {
            var result = await SendAsync<dynamic>(HttpMethod.Get, $"{SEGMENTS_RESOURCE}/{segmentId}/users/");
            var paginatedResult = CreatePaginatedResult<User>(result);

            return paginatedResult;
        }
    }
}
