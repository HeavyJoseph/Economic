
namespace Economic.Core.Entities
{
    public class Prestamo_Master : BaseEntity
    {
        public int PrestatarioId { get; set; }
        public int FiadorId { get; set; }
        public int EmpleadoId { get; set; }
        public int Importe { get; set; }
        public int Numero_Cuotas { get; set; }
        public int Interez_Pociento { get; set; }
        public System.DateTime Fecha_Solicitud { get; set; }
        public System.DateTime Fecha_Aprobado { get; set; }
        public int Plazo_dias { get; set; }
        public int EstadoId { get; set; }
    }
}
