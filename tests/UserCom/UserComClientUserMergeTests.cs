using Moq;
using Moq.Protected;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using UserCom;

namespace Tests.UserCom
{
    [TestFixture]
    public class UserComClientUserMergeTests
    {
        [Test, CustomAutoData]
        public async Task MergeAsync_posts_the_parent_and_the_merged_users_to_the_merge_endpoint(
            Mock<HttpMessageHandler> handler,
            string account,
            int parentId,
            int mergedId)
        {
            HttpMethod method = null;
            string path = null;
            string body = null;

            handler.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
                .Returns(async (HttpRequestMessage request, CancellationToken _) =>
                {
                    method = request.Method;
                    path = request.RequestUri.PathAndQuery;
                    body = await request.Content.ReadAsStringAsync();

                    return new HttpResponseMessage
                    {
                        StatusCode = HttpStatusCode.OK,
                        Content = new StringContent("{\"success\":true}"),
                        RequestMessage = request
                    };
                });

            var sut = new UserComClient(new UserComAuthenticator(account) { InnerHandler = handler.Object });

            await sut.Users.MergeAsync(parentId, new[] { mergedId });

            var json = JObject.Parse(body);

            Assert.Multiple(() =>
            {
                Assert.That(method, Is.EqualTo(HttpMethod.Post));
                Assert.That(path, Is.EqualTo("/api/public/users/merge/"));
                Assert.That((int)json["parent"], Is.EqualTo(parentId));
                Assert.That(json["users_list"], Is.Null);
                Assert.That(json["user_list"].ToObject<int[]>(), Is.EqualTo(new[] { mergedId }));
            });
        }
    }
}
