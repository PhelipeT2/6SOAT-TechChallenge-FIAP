namespace Domain.Entities
{
    public class Produto
    {
        public long Id { get; set; }    
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public Categoria Categoria { get; set; }  
    }
}
