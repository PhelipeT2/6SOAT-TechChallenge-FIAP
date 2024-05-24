namespace Domain.Entities
{
    public class PedidoProduto
    {
        public PedidoProduto()
        {
            
        }
        public PedidoProduto(long produtoId, int quantidade, string observacao)
        {
            ProdutoId = produtoId;
            Quantidade = quantidade;
            Observacao = observacao;    
        }
        public long Id { get; private set; }    
        public Pedido Pedido { get; private set; }
        public long PedidoId { get; private set; }
        public Produto Produto { get; private set; }
        public long ProdutoId { get; private set; }
        public int Quantidade { get; private set; }
        public string Observacao { get; private set; }
    }
}
