using Microsoft.Extensions.DependencyInjection;
using DevCA.Data.Context;
using DevCA.Business.Interfaces;
using DevCA.Data.Repository;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using DevCA.App.Extensions;
using DevCA.Business.Notifications;
using DevCA.Business.Services;

namespace DevCA.App.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddSingleton<IValidationAttributeAdapterProvider, MoedaValidationAttributeAdapterProvider>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IProdutoService, ProdutoService>();

            return services;
        }
    }
}
