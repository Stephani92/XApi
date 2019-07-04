using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using XApi.Domain.Entities;

namespace XApi.Infra.Persistence
{
    public class XApiContext: DbContext
    {

        public XApiContext():base("XApiConnect")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public IDbSet<Pessoa> Pessoas { get; set; }
        public IDbSet<Plataforma> Plataformas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // seta o schema default
            // modelBuilder.HasDefaultSchema("Apoio");

            //Remover pluralizaçao 
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //Remove exclusao em cascata
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Seta para varchar
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            //add entidades mapeando auto via Assembly

            modelBuilder.Configurations.AddFromAssembly(typeof(XApiContext).Assembly);

            base.OnModelCreating(modelBuilder); 
        }

    }
}
