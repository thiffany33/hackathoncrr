using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Mapping
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(q => q.Id);
            builder.Property(q => q.Nome).IsRequired().HasMaxLength(500);
            builder.Property(q => q.Telefone).IsRequired().HasMaxLength(20);
            builder.Property(q => q.Email).IsRequired().HasMaxLength(150);
            builder.Property(q => q.Renda).IsRequired();
        }
    }
}
