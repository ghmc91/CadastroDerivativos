using CadastroDerivativos.Application.Services;
using CadastroDerivativos.Data.Repositories;
using CadastroDerivativos.Domain.Interfaces;
using CadastroDerivativos.Domain.Interfaces.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CadastroDerivativos.Infra.IoC
{
    public static class DependencyInjectConfig
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<IEquityOptRepository, EquityOptRepository>();
            services.AddTransient<IEquityOptService, EquityOptService>();

            services.BuildServiceProvider();
        }
    }
}
