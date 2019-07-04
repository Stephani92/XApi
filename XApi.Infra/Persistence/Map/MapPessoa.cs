using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using XApi.Domain.Entities;

namespace XApi.Infra.Persistence.Map
{
    class MapPessoa:EntityTypeConfiguration<Pessoa>
    {
        public MapPessoa()
        {
            ToTable("Pessoa");
            
            //Email
            Property(p => p.Email.End).HasMaxLength(200).IsRequired().HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("UK_PESSOA_EMAIL"){IsUnique = true})).HasColumnName("Email");

            //Nome
            Property(p => p.Nome.FirsName).HasMaxLength(50).IsRequired().HasColumnName("PrimeiroNome");
            Property(p => p.Nome.LastName).HasMaxLength(50).IsRequired().HasColumnName("UltimoNome");
            Property(p => p.Senha).IsRequired();
            Property(p => p.status).IsRequired();
        }
    }
}
