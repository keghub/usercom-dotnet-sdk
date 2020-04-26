using System.Collections.Generic;
using System.Threading.Tasks;
using UserCom.Model.Segments;
using UserCom.Model.Users.Requests;

namespace UserCom.Model.Users
{
    public interface IUserComCustomIdUsersClient
    {
         Task<User> UpdateAsync(UpdateOrCreateUserRequest request);

         Task<User> FindByCustomIdAsync(string userId);

         Task DeleteAsync(string userId);

        Task<PaginatedResult<Segment>> GetSegmentsAsync(string userId);

        Task<AddTagResult> AddTagAsync(string userId, string tagName);
        
        Task RemoveTagAsync(string userId, string tagName);

        Task<int> AddListAsync(string userId, int listId);

        Task RemoveListAsync(string userId, int listId);

        Task SetAttributeAsync(string userId, (string attribute, object value) attribute);

        Task SetMultipleAttributesAsync(string userId, Dictionary<string, object> attributes);

        Task RemoveAttributeAsync(string userId, string attributeName);

        Task<PaginatedResult<UserPingHit>> GetPingHitsAsync(string userId);

        Task<PaginatedResult<UserTimeline>> GetTimelineAsync(string userId);

        Task<PaginatedResult<UserEvent>> GetEventsAsync(string userId);

        Task<PaginatedResult<UserEmail>> GetEmailsAsync(string userId);

        Task<PaginatedResult<UserProductEvent>> GetProductEventsAsync(string userId);

        Task<string> MassUpdateAttributeAsync(IEnumerable<string> userIds, string attribute, string value);

        Task MassUpdateCustomAttributeAsync(IEnumerable<string> userIds, string attribute, object value);
    }
}