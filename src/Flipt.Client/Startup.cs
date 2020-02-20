using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flipt.Client
{
    public static class Startup
    {
        public static IServiceCollection AddFliptClient(this IServiceCollection services, Action<IServiceProvider, FliptClientConfiguration> configBuilder = null, ServiceLifetime lifetime = ServiceLifetime.Scoped)
        {
            services.Add(new ServiceDescriptor(typeof(IFliptAPIClient), typeof(FliptAPIClient), lifetime));
            if (configBuilder != null)
            {
                services.Add(new ServiceDescriptor(typeof(FliptClientConfiguration), (sp) =>
                {
                    var cfg = new FliptClientConfiguration();
                    configBuilder?.Invoke(sp, cfg);
                    return cfg;
                }, lifetime));
            }

            return services;
        }
    }
}
