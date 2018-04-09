
namespace Economic.Core.Entities
{
    public class Documentos : BaseEntity
    {
        public int EntidadId { get; set; }
        public int Prestamo_MasterId { get; set; }
        public string CaraA { get; set; }
        public string CaraB { get; set; }
        public string Descripcion { get; set; }
    }
}
