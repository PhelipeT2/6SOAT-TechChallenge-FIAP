using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Config
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                   .UseIdentityColumn();

            builder.OwnsOne(x => x.Cpf)
                   .Property(x => x.Numero)
                   .HasColumnName("CPF");

            builder.OwnsOne(x => x.Email)
                   .Property(x => x.Valor)
                   .HasColumnName("Email");
        }
    }
}
