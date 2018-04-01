
using Economic.Core.Entities;

namespace Economic.Core.Map
{
    public class PrestamosDetalleEstadosMap : BaseMap<Prestamos_Detalle_Estados>
    {
        public PrestamosDetalleEstadosMap()
        {
            this.Property(x => x.Descripcion).HasColumnName("Descripcion");
            this.ToTable("Prestamos_Detalle_Estados", "WEB");
        }
    }
}
