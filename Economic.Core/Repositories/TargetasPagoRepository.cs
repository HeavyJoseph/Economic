
namespace Economic.Core.Repositories
{
    public class TargetasPagoRepository : BaseRepository<Entities.TargetasPago>
    {
        public void AddTargeta(Entities.TargetasPago nuevaTargeta)
        {
            this.Add(nuevaTargeta);
            this.SaveChanges();
        }

        public void DesvincularTargeta(int targetaId)
        {
            this.Delete(x => x.Id == targetaId);
            this.SaveChanges();
        }

        public void UpdateTargeta(Entities.TargetasPago targeta)
        {
            this.Update(targeta);
            this.SaveChanges();
        }
    }
}
