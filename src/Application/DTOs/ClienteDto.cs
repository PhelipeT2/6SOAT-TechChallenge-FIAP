using Domain.ValueObjects;

namespace Application.DTOs
{
    public class ClienteDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
    }
}
