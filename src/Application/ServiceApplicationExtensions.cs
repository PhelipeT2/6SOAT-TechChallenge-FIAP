using Application.DTOs;
using Application.UseCase;
using Application.UseCase.Produtos;
using AutoMapper;
using Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.ComponentModel;

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
                cfg.CreateMap<ClienteDto, Cliente>().ReverseMap()
                    .ForMember(x => x.Email, opt => opt.MapFrom(u => u.Email.Valor))
                    .ForMember(x => x.Cpf, opt => opt.MapFrom(u => u.Cpf.Numero));

                cfg.CreateMap<PedidoProdutoDto, PedidoProduto>().ReverseMap()
                        .ForMember(x => x.Nome, opt => opt.MapFrom(u => u.Produto.Descricao))
                        .ForMember(x => x.ValorUnitario, opt => opt.MapFrom(u => u.Produto.Valor));
                cfg.CreateMap<PedidoDto, Pedido>().ReverseMap()
                .ForMember(x => x.Status, opt => opt.MapFrom(u => u.Status.GetEnumDescription()));                     
            });

            IMapper mapper = config.CreateMapper();

            services.AddSingleton(mapper);

            return services;
        }

        public static string GetEnumDescription(this Enum value)
        {
            if (value == null) { return ""; }

            DescriptionAttribute attribute = value.GetType()
                    .GetField(value.ToString())
                    ?.GetCustomAttributes(typeof(DescriptionAttribute), false)
                    .SingleOrDefault() as DescriptionAttribute;
            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}

