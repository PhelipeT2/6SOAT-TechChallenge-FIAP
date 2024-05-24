using Domain.Enums;

namespace Domain.Entities
{
    public class Pedido
    {
        public Pedido()
        {
            
        }
        public Pedido(long? clienteId, ICollection<PedidoProduto> pedidoProdutos)
        {
            ClienteId = clienteId > 0 ? clienteId : null;
            DataCriacao = DateTime.Now;
            Status = StatusEnum.Pendente;
            Produtos = pedidoProdutos;
            ValorTotal = pedidoProdutos.Sum(x => x.Quantidade * x.Produto.Valor);
        }

       
        public long Id { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public Cliente? Cliente { get; private set; }
        public long? ClienteId { get; private set; }
        public decimal ValorTotal { get; private set; }
        public StatusEnum Status { get; private set; }
        public virtual ICollection<PedidoProduto> Produtos { get; private set; }
    }
}
