
using Economic.Core.Entities;

namespace Economic.Core.Map
{
    public class PrestamoDetalleMap : BaseMap<Prestamo_Detalle>
    {
        public PrestamoDetalleMap()
        {
            this.Property(x => x.Amortizacion).HasColumnName("Amortizacion");
            this.Property(x => x.Cuota_Numero).HasColumnName("Cuota_Numero");
            this.Property(x => x.Descuento).HasColumnName("Descuento");
            this.Property(x => x.EstadoId).HasColumnName("EstadoId");
            this.Property(x => x.Fecha_Pago).HasColumnName("Fecha_Pago");
            this.Property(x => x.Fecha_Vencimiento).HasColumnName("Fecha_Vencimiento");
            this.Property(x => x.Interez).HasColumnName("Interez");
            this.Property(x => x.Mora).HasColumnName("Mora");
            this.Property(x => x.PagoCapital).HasColumnName("PagoCapital");
            this.Property(x => x.Prestamo_Master_ID).HasColumnName("Prestamo_Master_ID");
            this.Property(x => x.Saldo).HasColumnName("Saldo");
            this.ToTable("Prestamos_Estados", "WEB");
        }
    }
}
