using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace data.Configuring
{
    public class FormacaoConfigure : IEntityTypeConfiguration<Formacao>
    {
        public void Configure(EntityTypeBuilder<Formacao> builder)
        {
          builder.HasKey(p => p.Id);
          builder.HasIndex(p => p.Nome).IsUnique();
          builder.Property(p => p.Nome).HasColumnType("VARCHAR(100)").IsRequired();
          
        }
    }
}