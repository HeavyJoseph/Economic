
using Economic.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

using Economic.Core.Exceptions;

namespace Economic.Core.Repositories
{
    internal interface IBaseRepository<TEntity>
        where TEntity : BaseEntity
    {
        /// <summary>
        /// Retorna una Entidad de la base de datos que coincida con las expresion.
        /// </summary>
        /// <param name="expression">Recibe la expresion de busqueda por coincidencia</param>
        /// <returns></returns>
        TEntity Find(Expression<Func<TEntity, bool>> expression);

        /// <summary>
        /// REtorna las <<Entidades>> que coincidan con las expression 
        /// </summary>
        /// <param name="expression">Recibe la expresion de busqueda por coincidencia</param>
        /// <returns></returns>
        IEnumerable<TEntity> Select(Expression<Func<TEntity, bool>> expression);

        /// <summary>
        /// Añade una nueva entidad al Repositorio.
        /// </summary>
        /// <param name="Entity">Recibe la entidad a añadir.</param>
        void Add(TEntity Entity);

        /// <summary>
        /// Elimina una Entidad del Repositorio.
        /// </summary>
        /// <param name="Entity">Recibe la enidad a eliminar</param>
        void Delete(TEntity Entity);

        /// <summary>
        /// Establece definitivamente todos los cambios hechos en el Repositorio
        /// </summary>
        void SaveChanges();

        /// <summary>
        /// Actualiza una entidad en el Repositorio.
        /// </summary>
        /// <param name="Entity">Recibe la Entoidad que se va a ser Actualizada.</param>
        void Update(TEntity Entity);

        /// <summary>
        /// Retorma una confirmacion de que una entidad existe en el repositorio.
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        bool Exists(Expression<Func<TEntity, bool>> expression);
    }

    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : BaseEntity
    {
        private EconomicDBContext context;

        private DbSet<TEntity> dbSet
        {
            get
            {
                return this.context.Set<TEntity>();
            }
        }

        internal BaseRepositoryException exception = new BaseRepositoryException();

        public BaseRepository()
        {
            this.context = new EconomicDBContext();
        }

        public TEntity Find(Expression<Func<TEntity, bool>> expression)
        {
            return this.dbSet.Where(expression).FirstOrDefault() as TEntity;
        }

        public IEnumerable<TEntity> Select(Expression<Func<TEntity, bool>> expression)
        {
            return this.dbSet.Where(expression).Select(x => x) as IEnumerable<TEntity>;
        }

        public void Add(TEntity Entity)
        {
            this.dbSet.Add(Entity);
        }

        public void Delete(TEntity Entity)
        {
            this.dbSet.Remove(Entity);
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        public void Update(TEntity Entity)
        {
            this.context.Entry(Entity).State = EntityState.Modified;
        }

        public bool Exists(Expression<Func<TEntity, bool>> expression)
        {
            var entity = this.dbSet.Where(expression);

            if (entity.Count() != 0)
                return true;
            else
                return false;
        }
    }
}
