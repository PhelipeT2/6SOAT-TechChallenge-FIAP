using Application.DTOs;
using Application.UseCase;
using AutoMapper;
using Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ServiceApplicationExtensions
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddTransient<IClienteUseCase, ClienteUseCase>();
            services.AddTransient<IPedidoUseCase, PedidoUseCase>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PedidoProdutoDto, PedidoProduto>().ReverseMap();
                cfg.CreateMap<PedidoDto, Pedido>().ReverseMap();                     
            });

            IMapper mapper = config.CreateMapper();

            services.AddSingleton(mapper);

            return services;
        }
    }
}

