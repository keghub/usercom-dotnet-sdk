using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using UserCom;
using UserCom.Authentication;
using UserCom.Model.Tags;

namespace Integration
{
    public class TTagsClient
    {
        private IUserComTagsClient _client;

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
                var response = await _client.GetAllAsync();

                Assert.That(response.Count, Is.GreaterThan(1));
            });
        }
    }
}
