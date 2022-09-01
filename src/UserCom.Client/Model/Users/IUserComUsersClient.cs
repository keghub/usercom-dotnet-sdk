using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserCom.Model.Segments;
using UserCom.Model.Users.Requests;

namespace UserCom.Model.Users
{
    public interface IUserComUsersClient
    {
        Task<User> CreateAsync(CreateUserRequest request);

        Task<User> UpdateAsync(UpdateUserRequest request);

        Task<UpdateOrCreateUserResponse> UpdateOrCreateAsync(UpdateOrCreateUserRequest request);

        Task<IReadOnlyList<User>> FindByEmailAsync(string email);

        Task<User> FindByKeyAsync(string key);

        Task<User> FindByPhoneNumberAsync(string phoneNumber);

        Task<PaginatedResult<User>> FindByDateAsync(DateSearchType searchType, DateTime min, DateTime max);

        Task DeleteAsync(int id);

        Task<PaginatedResult<User>> FilterByCustomAttributesAsync(IEnumerable<CustomAttributeFilter> filters);

        Task<User> FindByIdAsync(int id);

        Task<PaginatedResult<User>> FilterAsync(IEnumerable<UserFilter> filters);

        Task<PaginatedResult<Segment>> GetSegmentsAsync(int userId);

        Task<AddTagResult> AddTagAsync(int userId, string tagName);

        Task RemoveTagAsync(int userId, string tagName);

        Task<int> AddListAsync(int userId, int listId);

        Task RemoveListAsync(int userId, int listId);

        Task SetAttributeAsync(int userId, (string attribute, object value) attribute);

        Task SetMultipleAttributesAsync(int userId, Dictionary<string, object> attributes);

        Task RemoveAttributeAsync(int userId, string attributeName);

        Task<PaginatedResult<UserPingHit>> GetPingHitsAsync(int userId);

        Task<PaginatedResult<UserTimeline>> GetTimelineAsync(int userId);

        Task<PaginatedResult<UserEvent>> GetEventsAsync(int userId);

        Task<PaginatedResult<UserEmail>> GetEmailsAsync(int userId);

        Task<PaginatedResult<UserProductEvent>> GetProductEventsAsync(int userId);

        Task<string> MassUpdateAttributeAsync(IEnumerable<int> userIds, string attribute, string value);

        Task MassUpdateCustomAttributeAsync(IEnumerable<int> userIds, string attribute, object value);
    }
}