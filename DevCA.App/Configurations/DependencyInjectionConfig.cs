using Microsoft.Extensions.DependencyInjection;
using DevCA.Data.Context;
using DevCA.Business.Interfaces;
using DevCA.Data.Repository;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using DevCA.App.Extensions;

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

            return services;
        }
    }
}
