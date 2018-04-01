
using System.Data.Entity.ModelConfiguration;

namespace Economic.Core.Map
{
    public class EntidadesTiposMap : EntityTypeConfiguration<Entities.Entidades_Tipos>
    {
        public EntidadesTiposMap()
        {
            this.Property(x => x.Descripcion).HasColumnName("Descripcion");
            this.ToTable("Entidades_Tipos", "WEB");
        }
    }
}
