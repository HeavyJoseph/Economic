
using System.Data.Entity;

namespace Economic.Core
{
    public class EconomicDBContext : DbContext
    {
        public EconomicDBContext() : base("name=EconomicStrConnecion")
        {
            Database.SetInitializer<EconomicDBContext>(null);
        }

        public DbSet<Entities.Bienes_Declarados> Bienes_Declarados { get; set; }
        public DbSet<Entities.Documentos> Documentos { get; set; }
        public DbSet<Entities.Entidades> Entidades { get; set; }
        public DbSet<Entities.Entidades_Tipos> Entidades_Tipos { get; set; }
        public DbSet<Entities.Prestamos_Detalle_Estados> Prestamos_Detalle_Estados { get; set; }
        public DbSet<Entities.Prestamos_Estados> Prestamos_Estados { get; set; }
        public DbSet<Entities.Prestamo_Detalle> Prestamo_Detalle { get; set; }
        public DbSet<Entities.Prestamo_Master> Prestamo_Master { get; set; }
        public DbSet<Entities.TargetasPago> TargetasPago { get; set; }

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
            modelBuilder.Configurations.Add(new Map.TargetasPagoMap());
        }
    }
}
