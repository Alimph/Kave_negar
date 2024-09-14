using KaveNegarApi.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace KaveNegarApi.Services
{
    public static class KaveNegarConfigure
    {
        public static IServiceCollection AddKaveNegarConfigure(this IServiceCollection services, Action<KaveNegarOption> setup)
        {
            services.AddScoped<ISmsSenderService, SmsSenderService>();
            services.Configure(setup);
            return services;
        }
    }
}
