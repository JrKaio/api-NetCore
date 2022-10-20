using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping{

    public class UserMap : IEntityTypeConfiguration<userEntity>
    {
        public void Configure(EntityTypeBuilder<userEntity> builder)
        {
            builder.ToTable("User") ;//Nome da Tabela
            builder.HasKey (p => p.id); //Chave primária
            builder.HasIndex(p => p.Email)
            .IsUnique(); //Sigrnifica que ele não irá deixar implementar um email igual
            builder.Property(u => u.Name)
            .IsRequired() //Significa que ela é obrgatória
            .HasMaxLength(60); // Máximo de 60 caracteres  

            builder.Property(u => u.Email)
            .HasMaxLength(100);

        }
    }

}
