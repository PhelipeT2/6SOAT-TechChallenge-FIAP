namespace Application.DTOs
{
    public class CadastrarPedidoDto
    {
        public long? ClienteId { get; set; }
        public virtual ICollection<PedidoProdutoBaseDto> Produtos { get; set; }
        public bool Viagem { get; set; }
    }
}
