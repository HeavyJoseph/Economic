
using System.Data.Entity.ModelConfiguration;
using Economic.Core.Entities;

namespace Economic.Core.Map
{
    public class BienesDeclaradosMap : EntityTypeConfiguration<Bienes_Declarados>
    {
        public BienesDeclaradosMap()
        {
            this.Property(x => x.Cantidad).HasColumnName("Cantidad");
            this.Property(x => x.Descripcion).HasColumnName("Descripcion");
            this.Property(x => x.EntidadId).HasColumnName("EntidadId");
            this.Property(x => x.Prestamo_MasterId).HasColumnName("Prestamo_MasterId");
            this.ToTable("Bienes_Declarados", "WEB");
        }
    }
}
