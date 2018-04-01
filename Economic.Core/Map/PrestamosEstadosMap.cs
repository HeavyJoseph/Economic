
using Economic.Core.Entities;

namespace Economic.Core.Map
{
    public class PrestamosEstadosMap : BaseMap<Prestamos_Estados>
    {
        public PrestamosEstadosMap()
        {
            this.Property(x => x.Descripcion).HasColumnName("Descripcion");
            this.ToTable("Prestamos_Estados", "WEB");
        }
    }
}
