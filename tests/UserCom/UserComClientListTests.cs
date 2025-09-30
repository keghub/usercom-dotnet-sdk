﻿using Moq;
using Moq.Protected;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using UserCom;

namespace Tests.UserCom
{
    [TestFixture]
    public class UserComClientListTest
    {
        private const string ListResource = "/api/public/lists";

        [TestFixture]
        public class PaginatedResult_Next
        {
            [Test, CustomAutoData]
            public async Task PaginatedResult_Next_does_not_throw_if_nextUrl_from_userCom_throws_404(
                Mock<HttpMessageHandler> handler,
                string account)
            {
                var listAllUrl = $"{ListResource}/";
                var nextUrl = $"{ListResource}?cursor=101";
                
                // Initial request in GetAllAsync
                handler.Protected()
                    .Setup<Task<HttpResponseMessage>>(
                        "SendAsync",
                        ItExpr.Is<HttpRequestMessage>(m => m.RequestUri.PathAndQuery.Equals(listAllUrl)),
                        ItExpr.IsAny<CancellationToken>())
                    .ReturnsAsync(() => new HttpResponseMessage
                    {
                        StatusCode = HttpStatusCode.OK,
                        Content = new StringContent(JsonConvert.SerializeObject(new
                        {
                            count = 0,
                            results = Array.Empty<object>(),
                            next = $"https://{account}.user.com{nextUrl}"
                        })),
                        RequestMessage = new HttpRequestMessage(HttpMethod.Get, listAllUrl)
                    });

                // "Next" request
                handler.Protected()
                    .Setup<Task<HttpResponseMessage>>(
                        "SendAsync",
                        ItExpr.Is<HttpRequestMessage>(m => m.RequestUri.PathAndQuery.Equals(nextUrl)),
                        ItExpr.IsAny<CancellationToken>())
                    .ReturnsAsync(() => new HttpResponseMessage
                    {
                        StatusCode = HttpStatusCode.NotFound,
                        Content = new StringContent(JsonConvert.SerializeObject(new { })),
                        RequestMessage = new HttpRequestMessage(HttpMethod.Get, $"https://{account}.user.com{nextUrl}")
                    });

                var authenticator = new UserComAuthenticator(account)
                {
                    InnerHandler = handler.Object
                };

                var sut = new UserComClient(authenticator);

                var initial = await sut.Lists.GetAllAsync();

                Assert.DoesNotThrow(() =>
                {
                    var next = initial.Next.Value;
                });

                handler.Protected().Verify(
                    "SendAsync",
                    Times.Once(),
                    ItExpr.Is<HttpRequestMessage>(req => req.Method == HttpMethod.Get && req.RequestUri.PathAndQuery.Equals(listAllUrl)),
                    ItExpr.IsAny<CancellationToken>());

                handler.Protected().Verify(
                   "SendAsync",
                   Times.Once(),
                   ItExpr.Is<HttpRequestMessage>(req => req.Method == HttpMethod.Get && req.RequestUri.PathAndQuery.Equals(nextUrl)),
                   ItExpr.IsAny<CancellationToken>());

                handler.Protected().Verify(
                    "SendAsync",
                    Times.Exactly(2),
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>());
            }

            [Test, CustomAutoData]
            public async Task PaginatedResult_Next_returns_empty_paginatedResult_if_nextUrl_from_userCom_throws_404(
                Mock<HttpMessageHandler> handler,
                string account)
            {
                var listAllUrl = $"{ListResource}/";
                var nextUrl = $"{ListResource}?cursor=101";

                // Initial request in GetAllAsync
                handler.Protected()
                    .Setup<Task<HttpResponseMessage>>(
                        "SendAsync",
                        ItExpr.Is<HttpRequestMessage>(m => m.RequestUri.PathAndQuery.Equals(listAllUrl)),
                        ItExpr.IsAny<CancellationToken>())
                    .ReturnsAsync(() => new HttpResponseMessage
                    {
                        StatusCode = HttpStatusCode.OK,
                        Content = new StringContent(JsonConvert.SerializeObject(new
                        {
                            count = 0,
                            results = Array.Empty<object>(),
                            next = $"https://{account}.user.com{nextUrl}"
                        })),
                        RequestMessage = new HttpRequestMessage(HttpMethod.Get, listAllUrl)
                    });

                // "Next" request
                handler.Protected()
                    .Setup<Task<HttpResponseMessage>>(
                        "SendAsync",
                        ItExpr.Is<HttpRequestMessage>(m => m.RequestUri.PathAndQuery.Equals(nextUrl)),
                        ItExpr.IsAny<CancellationToken>())
                    .ReturnsAsync(() => new HttpResponseMessage
                    {
                        StatusCode = HttpStatusCode.NotFound,
                        Content = new StringContent(JsonConvert.SerializeObject(new { })),
                        RequestMessage = new HttpRequestMessage(HttpMethod.Get, $"https://{account}.user.com{nextUrl}")
                    });

                var authenticator = new UserComAuthenticator(account)
                {
                    InnerHandler = handler.Object
                };

                var sut = new UserComClient(authenticator);

                var initial = await sut.Lists.GetAllAsync();

                var result = initial.Next.Value;

                Assert.Multiple(() =>
                {
                    Assert.That(result, Is.Not.Null);
                    Assert.That(result.Count, Is.EqualTo(0));
                    Assert.That(result.Results, Is.Not.Null);
                    Assert.That(result.Results.Count, Is.EqualTo(0));
                    Assert.That(result.Next, Is.Null);
                    Assert.That(result.Previous, Is.Null);
                });
            }
        }
    }
}
