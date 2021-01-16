using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Mapping
{
    public class EmpresaMapping : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.HasKey(q => q.Id);
            builder.Property(q => q.Pessoa).IsRequired();
            builder.Property(q => q.RazaoSocial).IsRequired().HasMaxLength(300);
            builder.Property(q => q.Email).IsRequired().HasMaxLength(200);
            builder.Property(q => q.Telefone).IsRequired();
            builder.Property(q => q.CNPJ).IsRequired().HasMaxLength(15);
        }
    }
}
