
namespace Economic.Core.Entities
{
    public class Entidades : BaseEntity
    {
        public int TipoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Numero_Identidad { get; set; }
        public int Telefono { get; set; }
        public int Celular { get; set; }
        public string Direccion { get; set; }
        public string Estado_Civil { get; set; }
        public System.DateTime Fecha_Nacimiento { get; set; }
        public string Genero { get; set; }
        public string Correo { get; set; }
        public string Nombre_Empresa { get; set; }
        public string Rol_Empresa { get; set; }
        public int Telefono_Empresa { get; set; }
        public int Ingresos { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
    }
}
