using System.Net.Http;
using System.Threading.Tasks;
using UserCom.Model;
using UserCom.Model.Lists;

namespace UserCom
{
    public partial class UserComClient : IUserComListsClient
    {
        private static string LISTS_RESOURCE = "/api/public/lists";

        async Task<List> IUserComListsClient.CreateAsync(string name, string description)
        {
            var result = await SendAsync<dynamic, List>(HttpMethod.Post, $"{LISTS_RESOURCE}/", new { name, description });

            return result;
        }

        async Task IUserComListsClient.DeleteAsync(int id)
        {
            await SendAsync(HttpMethod.Delete, $"{LISTS_RESOURCE}/{id}/");
        }

        async Task<PaginatedResult<List>> IUserComListsClient.GetAllAsync()
        {
            var result = await SendAsync<dynamic>(HttpMethod.Get, $"{LISTS_RESOURCE}/");
            var paginatedResult = CreatePaginatedResult<List>(result);

            return paginatedResult;
        }

        async Task IUserComListsClient.UpdateAsync(int id, string? name, string? description)
        {
            await SendAsync<dynamic>(HttpMethod.Put, $"{LISTS_RESOURCE}/{id}/", new { name, description });
        }
    }
}
