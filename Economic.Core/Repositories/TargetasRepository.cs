
namespace Economic.Core.Repositories
{
    public class TargetasRepository : BaseRepository<Entities.Targetas>
    {
        public void AddTargeta(Entities.Targetas nuevaTargeta)
        {
            this.Add(nuevaTargeta);
            this.SaveChanges();
        }

        public void DesvincularTargeta(int targetaId)
        {
            this.Delete(x => x.Id == targetaId);
            this.SaveChanges();
        }

        public void UpdateTargeta(Entities.Targetas targeta)
        {
            this.Update(targeta);
            this.SaveChanges();
        }
    }
}
