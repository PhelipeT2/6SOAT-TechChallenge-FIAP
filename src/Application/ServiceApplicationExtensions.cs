using Application.UseCase;
using Application.UseCase.Produtos;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ServiceApplicationExtensions
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddScoped<IClienteUseCase, ClienteUseCase>();
            services.AddScoped<IProdutosUseCase, ProdutosUseCase>();
            return services;
        }
    }
}

