using Application.UseCase;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ServiceApplicationExtensions
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddTransient<IClienteUseCase, ClienteUseCase>();
            return services;
        }
    }
}

