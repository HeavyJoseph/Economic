
namespace Economic.Core.Map
{
    public class TargetasPagoMap : BaseMap<Entities.TargetasPago>
    {
        public TargetasPagoMap()
        {
            this.Property(x => x.EntidadId).HasColumnName("EntidadId");
            this.Property(x => x.Numero).HasColumnName("Numero");
            this.ToTable("TargetasPago", "WEB");
        }
    }
}
