namespace Application.DTOs
{
    public class CadastrarPedidoDto
    {
        public long? ClienteId { get; set; }
        public virtual ICollection<PedidoProdutoDto> Produtos { get; set; }
    }
}
