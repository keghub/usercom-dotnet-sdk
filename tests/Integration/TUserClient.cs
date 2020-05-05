using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using UserCom;
using UserCom.Authentication;
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

            Assert.That(response.Count, Is.GreaterThan(1));
        }

        [Test]
        public async Task NextFilterUsersShouldReturnNextObject()
        {
            var response = await _client.FilterAsync(new UserFilter[] { });
            var next = response.Next.Value;

            Assert.That(next, Is.Not.Null);
        }

        [Test]
        public void CreateUserShouldReturnOk()
        {
            const string EMAIL = "test2@educations.com";

            Assert.DoesNotThrowAsync(async () =>
            {
                var response = await _client.CreateAsync(new CreateUserRequest
                {
                    Email = EMAIL,
                    FirstName = "Integration",
                    LastName = "Tests",
                    UserId = "acustomuserid"
                });

                Assert.That(response.Email, Is.EqualTo(EMAIL));
            });
        }
    }
}