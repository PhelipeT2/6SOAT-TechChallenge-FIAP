using Domain.Enums;

namespace Application.DTOs
{
    public class PedidoDto
    {
        public long Id { get; set; }
        public DateTime DataCriacao { get; set; }       
        public ClienteDto Cliente { get; set; }
        public decimal ValorTotal { get; set; }
        public string Status { get; set; }
        public virtual ICollection<PedidoProdutoDto> Produtos { get; set; }
    }
}
