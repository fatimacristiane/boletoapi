using boleto.data.Context;
using boleto.data.Repository;
using boletoapi.business.Interfaces;
using boletoapi.business.Notificacoes;

namespace boleto.api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IBancoRepository, BancoRepository>();
            services.AddScoped<IBoletoRepository, BoletoRepository>();


            services.AddScoped<INotificador, Notificador>();
            

            return services;
        }
    }
}
