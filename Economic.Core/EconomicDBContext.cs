
using System.Data.Entity;

namespace Economic.Core
{
    public class EconomicDBContext : DbContext
    {
        public EconomicDBContext() : base("name=EconomicStrConnecion")
        {
            Database.SetInitializer<EconomicDBContext>(null);
        }

        public DbSet<Entities.Entidades_Tipos> Entidades_Tipos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Map.BienesDeclaradosMap());
            modelBuilder.Configurations.Add(new Map.DocumentosMap());
            modelBuilder.Configurations.Add(new Map.EntidadesMap());
            modelBuilder.Configurations.Add(new Map.EntidadesTiposMap());
            modelBuilder.Configurations.Add(new Map.PrestamoDetalleMap());
            modelBuilder.Configurations.Add(new Map.PrestamoMasterMap());
            modelBuilder.Configurations.Add(new Map.PrestamosDetalleEstadosMap());
            modelBuilder.Configurations.Add(new Map.PrestamosEstadosMap());
            modelBuilder.Configurations.Add(new Map.UsuariosMap());
        }
    }
}
