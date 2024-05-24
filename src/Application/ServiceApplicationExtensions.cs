using Application.DTOs;
using Application.UseCase;
using Application.UseCase.Produtos;
using AutoMapper;
using Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ServiceApplicationExtensions
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddScoped<IClienteUseCase, ClienteUseCase>();
            services.AddScoped<IPedidoUseCase, PedidoUseCase>();
            services.AddScoped<IProdutosUseCase, ProdutosUseCase>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PedidoProdutoBaseDto, PedidoProduto>().ReverseMap();
                cfg.CreateMap<PedidoProdutoDto, PedidoProduto>().ReverseMap()
                        .ForMember(x => x.Nome, opt => opt.MapFrom(u => u.Produto.Descricao));
                cfg.CreateMap<PedidoDto, Pedido>().ReverseMap()
                        .ForMember(x => x.Status, opt => opt.MapFrom(u => u.Status.ToString()));                     
            });

            IMapper mapper = config.CreateMapper();

            services.AddSingleton(mapper);

            return services;
        }
    }
}

