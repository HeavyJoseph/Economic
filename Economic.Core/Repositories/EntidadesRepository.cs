
namespace Economic.Core.Repositories
{
    public class EntidadesRepository : BaseRepository<Entities.Entidades>
    {
        public void RegistrarEntidad(Entities.Entidades nuevaEntidad)
        {
            this.Add(nuevaEntidad);
            this.SaveChanges();
        }

        public Entities.Entidades LogIn(string Usuario, string Password)
        {
            return this.Find(x => x.Usuario == Usuario && x.Password == Password);
        }
    }
}
