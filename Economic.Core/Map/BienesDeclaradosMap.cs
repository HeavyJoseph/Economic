
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
            this.ToTable("Bienes_Declarados", "WEB");
        }
    }
}
