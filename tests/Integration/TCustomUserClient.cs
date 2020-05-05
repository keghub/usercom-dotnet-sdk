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
            var authenticator = new TokenUserComAuthenticator("educationsmediagroup", "F630R3g4wzzuxTkLvgd5GkMFjojuJBbuor6qSoyTiUPc9EWl4F37VCbGhZOQj6E4");
            _client = new UserComClient(authenticator, new Mock<ILogger<UserComClient>>().Object);
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
