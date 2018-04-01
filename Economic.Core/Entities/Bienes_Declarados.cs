
namespace Economic.Core.Entities
{
    public class Bienes_Declarados : BaseEntity
    {
        public int EntidadId { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
    }
}
