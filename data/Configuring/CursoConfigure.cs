using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace data.Configuring
{
    public class CursoConfigure : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Descricao).HasColumnType("VARCHAR(250)").IsRequired();
            builder.Property(p => p.Duracao).HasColumnType("VARCHAR(20)").IsRequired();
           
        }
    }
}