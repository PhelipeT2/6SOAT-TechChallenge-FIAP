using Domain.Entities;
using System.ComponentModel;

namespace Domain.Enums
{
    public enum StatusEnum
    {
        [Description("Pagamento Pendente")]
        PagamentoPendente = 0,
        [Description("Recebido")]
        Recebido = 1,
        [Description("Em Preparação")]
        EmPreparacao = 2,
        [Description("Pronto")]
        Pronto = 3,
        [Description("Finalizado")]
        Finalizado = 4,
        [Description("Cancelado")]
        Cancelado = 5
    }
}