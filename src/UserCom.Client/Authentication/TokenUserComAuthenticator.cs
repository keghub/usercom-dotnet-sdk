using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace UserCom.Authentication
{
    public class TokenUserComAuthenticator  : UserComAuthenticator
    {
        private readonly string _token;

        public TokenUserComAuthenticator(string account, string token) : base(account)
        {
            _token = token ?? throw new ArgumentNullException(nameof(token));
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Token", _token);

            return base.SendAsync(request, cancellationToken);
        }
    }
}