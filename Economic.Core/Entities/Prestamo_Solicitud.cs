
namespace Economic.Core.Entities
{
    public class Prestamo_Solicitud : BaseEntity
    {
        public int PrestatarioId { get; set; }
        public int FiadorId { get; set; }
        public int TipoId { get; set; }
        public int Importe { get; set; }
        public int Numero_Cuotas { get; set; }
        public int Interez_Porciento { get; set; }
        public System.DateTime Fecha_Solicitud { get; set; }
        public int EstadoId { get; set; }
    }
}
