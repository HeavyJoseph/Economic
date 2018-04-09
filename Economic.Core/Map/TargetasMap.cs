
namespace Economic.Core.Map
{
    public class TargetasMap : BaseMap<Entities.Targetas>
    {
        public TargetasMap()
        {
            this.Property(x => x.EntidadId).HasColumnName("EntidadId");
            this.Property(x => x.Numero).HasColumnName("Numero");
            this.ToTable("TargetasPago", "WEB");
        }
    }
}
