
using Economic.Core.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Economic.Core.Map
{
    public abstract class BaseMap<TEntity> : EntityTypeConfiguration<TEntity>
        where TEntity : BaseEntity
    {
        public BaseMap()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasColumnName("Id").IsRequired();
        }
    }
}
