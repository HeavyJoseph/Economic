
using Economic.Core.Entities;

namespace Economic.Core.Map
{
    public class DocumentosMap : BaseMap<Documentos>
    {
        public DocumentosMap()
        {
            this.Property(x => x.CaraA).HasColumnName("CaraA");
            this.Property(x => x.CaraB).HasColumnName("CaraB");
            this.Property(x => x.Descripcion).HasColumnName("Descripcion");
            this.Property(x => x.EntidadId).HasColumnName("EntidadId");
            this.ToTable("Documentos", "WEB");
        }
    }
}
