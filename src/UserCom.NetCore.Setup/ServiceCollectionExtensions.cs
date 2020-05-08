using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using UserCom.Authentication;

namespace UserCom
{
    public static class ServiceCollectionExtensions
    {
        public static void AddUserCom(this IServiceCollection services, Action<UserComConfigurator> configuration = null)
        {
            services.AddSingleton<IUserComClient, UserComClient>();

            var cfg = new UserComConfigurator();

            configuration?.Invoke(cfg);

            cfg.ApplyConfiguration(services);
        }
    }

    public static class UserComConfiguratorExtensions
    {
        public static void UseToken(this UserComConfigurator configurator, string appName, string token)
        {
            configurator.AddConfiguration(services =>
            {
                services.AddSingleton<UserComAuthenticator, TokenUserComAuthenticator>(x => new TokenUserComAuthenticator(appName, token));
            });
        }
    }

    public class UserComConfigurator
    {
        private readonly List<Action<IServiceCollection>> _configurations = new List<Action<IServiceCollection>>();

        public void AddConfiguration(Action<IServiceCollection> configurationAction)
        {
            _configurations.Add(configurationAction);
        }

        public void ApplyConfiguration(IServiceCollection services)
        {
            foreach (var action in _configurations)
            {
                action(services);
            }
        }
    }
}
