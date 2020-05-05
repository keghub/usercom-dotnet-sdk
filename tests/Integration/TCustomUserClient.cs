using AutoFixture.NUnit3;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;
using UserCom;
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

        [Test, AutoData]
        public async Task FindByIdShouldReturnUser(string customId)
        {
            var response = await _client.FindByCustomIdAsync(customId);

            Assert.That(response.UserId, Is.EqualTo(customId));
        }
    }
}
