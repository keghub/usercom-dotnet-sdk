using System.Threading.Tasks;
using AutoFixture.NUnit3;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using UserCom;
using UserCom.Model.Users;
using UserCom.Model.Users.Requests;

namespace Integration
{
    public class TUserClient
    {
        private IUserComUsersClient _client;

        [SetUp]
        public void Setup()
        {
            _client = new UserComClient(ConfigHelper.GetAuthenticator(), Mock.Of<ILogger<UserComClient>>());
        }

        [TestCase(1)]
        public async Task GetUserByIdShouldReturnUser(int userId)
        {
            var response = await _client.FindByIdAsync(userId);

            Assert.That(response.Id, Is.EqualTo(userId));
        }

        [Test]
        public async Task FilterUsersShouldReturnListOfUsers()
        {
            var response = await _client.FilterAsync(new UserFilter[] { });

            Assert.That(response.Count, Is.GreaterThan(1));
        }

        [Test]
        public async Task NextFilterUsersShouldReturnNextObject()
        {
            var response = await _client.FilterAsync(new UserFilter[] { });
            var next = response.Next.Value;

            Assert.That(next, Is.Not.Null);
        }

        [Test, AutoData]
        public async Task CreateUserShouldReturnOk(string customName, string customId)
        {
            string email = $"{customName}@test.educations.com";

            var response = await _client.CreateAsync(new CreateUserRequest
            {
                Email = email,
                FirstName = customName,
                LastName = "Tests",
                UserId = customId
            });

            Assert.That(response.Email, Is.EqualTo(email));
        }
    }
}