using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using UserCom;
using UserCom.Model.Tags;

namespace Integration
{
    public class TTagsClient
    {
        private IUserComTagsClient _client;

        [SetUp]
        public void Setup()
        {
            _client = new UserComClient(ConfigHelper.GetAuthenticator(), Mock.Of<ILogger<UserComClient>>());
        }

        [Test]
        public void GetAllShouldReturnResults()
        {
            Assert.DoesNotThrowAsync(async () =>
            {
                var response = await _client.GetAllAsync();

                Assert.That(response.Count, Is.GreaterThan(1));
            });
        }
    }
}
