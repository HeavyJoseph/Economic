
namespace Economic.Core.Map
{
    public class PrestamoSolicitudMap : BaseMap<Entities.Prestamo_Solicitud>
    {
        public PrestamoSolicitudMap()
        {
            this.Property(x => x.EstadoId).HasColumnName("EstadoId");
            this.Property(x => x.Fecha_Solicitud).HasColumnName("Fecha_Solicitud");
            this.Property(x => x.FiadorId).HasColumnName("FiadorId");
            this.Property(x => x.Importe).HasColumnName("Importe");
            this.Property(x => x.Interez_Porciento).HasColumnName("Interez_Porciento");
            this.Property(x => x.Numero_Cuotas).HasColumnName("Numero_Cuotas");
            this.Property(x => x.PrestatarioId).HasColumnName("PrestatarioId");
            this.Property(x => x.TipoId).HasColumnName("TipoId");
            this.ToTable("Prestamo_Solicitud", "WEB");
        }
    }
}
