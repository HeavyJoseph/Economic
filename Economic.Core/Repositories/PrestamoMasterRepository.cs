
namespace Economic.Core.Repositories
{
    public class PrestamoMasterRepository : BaseRepository<Entities.Prestamo_Master>
    {
        public Entities.Prestamo_Master GetMasterByIdEntidad(int IdEntidad)
        {
            return this.Find(x => x.PrestatarioId == IdEntidad);
        }
    }
}
