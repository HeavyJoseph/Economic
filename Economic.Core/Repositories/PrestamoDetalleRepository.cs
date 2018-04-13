
using System.Collections.Generic;
using System.Linq;

namespace Economic.Core.Repositories
{
    public class PrestamoDetalleRepository : BaseRepository<Entities.Prestamo_Detalle>
    {
        public IEnumerable<Entities.Prestamo_Detalle> GetDetalleByIdMaster(int IdMaster)
        {
            return this.Select(x => x.Prestamo_Master_Id == IdMaster) as IEnumerable<Entities.Prestamo_Detalle>;
        }

        public void CalcularAmortizacion(int IdMaster)
        {
            var queryMaster = this.context.Prestamo_Master as IQueryable<Entities.Prestamo_Master>;
            
            var master = (from a in queryMaster
                          where a.Id == IdMaster
                          select a
                          ).FirstOrDefault();

            var numeroCuotas = master.Numero_Cuotas;
            var capital = master.Importe;
            var tasa = master.Interez_Porciento;

            var tablaAmortizacion = new List<Entities.Prestamo_Detalle>();

            for (var i = 0; i<numeroCuotas; i++)
            {
                tablaAmortizacion.Add(new Entities.Prestamo_Detalle {
                    Cuota_Numero = i,
                    Interez = capital*tasa/100,
                    Saldo = capital*(tasa/100)(1+tasa/100),
                });
            }

            this.context.SaveChanges();
        }
    }
}
