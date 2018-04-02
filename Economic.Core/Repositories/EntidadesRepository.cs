
using Economic.Core.Entities;

namespace Economic.Core.Repositories
{
    public class EntidadesRepository : BaseRepository<Entidades>
    {
        public EntidadesRepository()
        {
            //
        }

        //
        public void EntidadRegister(Entidades entidad, Usuarios usuario)
        {
            this.Add(entidad);
        }
    }
}
