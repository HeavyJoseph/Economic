
using Economic.Core.Entities;

namespace Economic.Core.Map
{
    public class UsuariosMap : BaseMap<Usuarios>
    {
        public UsuariosMap()
        {
            this.Property(x => x.Enable).HasColumnName("Enable");
            this.Property(x => x.EntidadId).HasColumnName("EntidadId");
            this.Property(x => x.Password).HasColumnName("Password");
            this.Property(x => x.UserName).HasColumnName("UserName");
            this.ToTable("Usuarios", "WEB");
        }
    }
}
