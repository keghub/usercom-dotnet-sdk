using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using UserCom;
using UserCom.Authentication;
using UserCom.Model.Users;

namespace Integration
{
    public class Tests
    {
        private IUserComUsersClient _client;

        [SetUp]
        public void Setup()
        {
            var authenticator = new TokenUserComAuthenticator("educationsmediagroup", "F630R3g4wzzuxTkLvgd5GkMFjojuJBbuor6qSoyTiUPc9EWl4F37VCbGhZOQj6E4");
            _client = new UserComClient(authenticator, new Mock<ILogger<UserComClient>>().Object);
        }

        [Test]
        public void GetUserByIdShouldReturnUser()
        {
            Assert.DoesNotThrowAsync(async () =>
            {
                var response = await _client.FindByIdAsync(1);
            });
        }

        [Test]
        public async Task FilterUsersShouldReturnListOfUsers()
        {
            var response = await _client.FilterAsync(new UserFilter[] { });

            Assert.Greater(response.Count, 1);
        }

        [Test]
        public async Task NextFilterUsersShouldReturnNextObject()
        {
            var response = await _client.FilterAsync(new UserFilter[] { });
            var next = response.Next.Value;

            Assert.NotNull(next);
        }
    }
}