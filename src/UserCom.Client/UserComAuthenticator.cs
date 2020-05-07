using System;
using System.Net.Http;

namespace UserCom
{
    public class UserComAuthenticator : DelegatingHandler
    {
        private const string apiUrl = "https://{0}.user.com/api/public/";

        public UserComAuthenticator(string account) : base()
        {
            if (account == null)
            {
                throw new ArgumentNullException(nameof(account));
            }

            if(string.IsNullOrWhiteSpace(account))
            {
                throw new ArgumentException("Cannot be empty", nameof(account));
            }

            InnerHandler = new HttpClientHandler();
            ServiceUri = new Uri(string.Format(apiUrl, account));
        }

        public virtual Uri ServiceUri { get; }
    }
}