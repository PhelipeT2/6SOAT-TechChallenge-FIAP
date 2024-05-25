using System.ComponentModel;

namespace Domain.Enums
{
    public enum StatusEnum
    {
        [Description("Pagamento Pendente")]
        PagamentoPendente = 0,
        Recebido,
        [Description("Em Preparação")]
        EmPreparacao,
        Pronto,
        Finalizado,
        Cancelado
    }
}
