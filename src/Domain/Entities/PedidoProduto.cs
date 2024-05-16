namespace Domain.Entities
{
    public class PedidoProduto
    {
        public long Id { get; set; }    
        public Pedido Pedido { get; set; }
        public long PedidoId { get; set; }
        public Produto Produto { get; set; }
        public long ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public string Observacao { get; set; }
    }
}
