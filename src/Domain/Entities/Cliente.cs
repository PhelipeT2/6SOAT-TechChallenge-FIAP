using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Cliente
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Email Email { get; set; }
        public CPF Cpf { get; set; }
    }
}
