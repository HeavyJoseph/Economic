
using System.Collections.Generic;
using System.Linq;

namespace Economic.Core.Repositories
{
    public class PrestamoDetalleRepository : BaseRepository<Entities.Prestamo_Detalle>
    {
        public IEnumerable<Entities.Prestamo_Detalle> GetDetalleByIdMaster(int IdMaster)
        {
            return this.Select(x => x.Prestamo_Master_Id == IdMaster);
        }

        public void CalcularAmortizacion(int IdMaster)
        {
            var queryMaster = this.context.Prestamo_Master as IQueryable<Entities.Prestamo_Master>;

            var master = (from a in queryMaster
                          where a.Id == IdMaster
                          select a
                          ).FirstOrDefault();

            //
        }
    }
}
