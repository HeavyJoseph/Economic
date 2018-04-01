
using Economic.Core.Entities;

namespace Economic.Core.Map
{
    public class EntidadesMap : BaseMap<Entidades>
    {
        public EntidadesMap()
        {
            this.Property(x => x.Apellido).HasColumnName("Apellido");
            this.Property(x => x.Celular).HasColumnName("Celular");
            this.Property(x => x.Correo).HasColumnName("Correo");
            this.Property(x =>  x.Descripcion_Laboral).HasColumnName("Descripcion_Laboral");
            this.Property(x => x.Descripcion_Vivienda).HasColumnName("Descripcion_Vivienda");
            this.Property(x => x.Direccion).HasColumnName("Direccion");
            this.Property(x => x.Enable).HasColumnName("Enable");
            this.Property(x => x.Estado_Civil).HasColumnName("Estado_Civil");
            this.Property(x => x.Fecha_Nacimiento).HasColumnName("Fecha_Nacimiento");
            this.Property(x => x.Genero).HasColumnName("Genero");
            this.Property(x => x.Nombre).HasColumnName("Nombre");
            this.Property(x => x.Numero_Identidad).HasColumnName("Numero_Identidad");
            this.Property(x => x.Telefono).HasColumnName("Telefono");
            this.Property(x => x.TipoId).HasColumnName("TipoId");
            this.ToTable("Entidades", "WEB");
        }
    }
}
