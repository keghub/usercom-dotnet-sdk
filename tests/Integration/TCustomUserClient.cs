using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using UserCom;
using UserCom.Authentication;
using UserCom.Model.Users;

namespace Integration
{
    public class TCustomUserClient
    {
        private IUserComCustomIdUsersClient _client;

        [SetUp]
        public void Setup()
        {
            _client = new UserComClient(ConfigHelper.GetAuthenticator(), Mock.Of<ILogger<UserComClient>>());
        }

        [Test]
        public void FindByIdShouldReturnUser()
        {
            const string CUSTOM_ID = "acustomuserid";
            Assert.DoesNotThrowAsync(async () =>
            {
                var response = await _client.FindByCustomIdAsync(CUSTOM_ID);

                Assert.That(response.UserId, Is.EqualTo(CUSTOM_ID));
            });
        }
    }
}
