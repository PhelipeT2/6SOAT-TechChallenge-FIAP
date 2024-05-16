using Domain.Enums;

namespace Domain.Entities
{
    public class Pedido
    {
        public long Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public Cliente Cliente { get; set; }
        public long? ClienteId { get; set;}
        public decimal ValorTotal { get; set; }
        public StatusEnum Status { get; set; }
        public virtual ICollection<PedidoProduto> Produtos { get; set; }
    }
}
