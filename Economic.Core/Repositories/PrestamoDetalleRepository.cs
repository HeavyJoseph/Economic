
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
            var redito = master.Interez_Porciento/100;
            
            for (var i = 0; i<numeroCuotas; i++)
            {
                var interez = capital * redito;
                var saldo = capital * redito * (1 + redito) ^ numeroCuotas / ((1 + redito) ^ numeroCuotas + 1);

                this.context.Prestamo_Detalle.Add(new Entities.Prestamo_Detalle {
                    Cuota_Numero = i,
                    Interez = interez,
                    Saldo = ,
                    Amortizacion = 
                });
            }

            this.context.SaveChanges();
        }
    }
}
