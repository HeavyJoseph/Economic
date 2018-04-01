
namespace Economic.Core.Entities
{
    public class Prestamo_Detalle : BaseEntity
    {
        public int Prestamo_Master_ID { get; set; }
        public System.DateTime Fecha_Vencimiento { get; set; }
        public System.DateTime Fecha_Pago { get; set; }
        public int Cuota_Numero { get; set; }
        public int PagoCapital { get; set; }
        public int Interez { get; set; }
        public int Amortizacion { get; set; }
        public int Mora { get; set; }
        public int Descuento { get; set; }
        public int Saldo { get; set; }
        public int EstadoId { get; set; }
    }
}
