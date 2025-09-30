using AutoFixture.NUnit3;
using NUnit.Framework;
using System.Threading.Tasks;
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
            _client = new UserComClient(ConfigHelper.GetAuthenticator());
        }

        [Test, AutoData]
        public async Task GetAllShouldReturnResults()
        {
            var response = await _client.GetAllAsync();

            Assert.That(response.Count, Is.GreaterThan(1));
        }
    }
}
