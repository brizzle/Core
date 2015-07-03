using System.Collections.Generic;

namespace Core.Contracts
{
    /// <summary>
    /// The repository base interface.
    /// </summary>
    public interface IRepositoryBase
    {

    }

    /// <summary>
    /// The repository base interface.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepositoryBase<TEntity> : IRepositoryBase
        where TEntity : IEntityBase, new()
    {
        /// <summary>
        /// Adds the entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>The entity.</returns>
        TEntity Add(TEntity entity);

        /// <summary>
        /// Gets a collection of entities.
        /// </summary>
        /// <returns>Collection of entities.</returns>
        IEnumerable<TEntity> Get();

        /// <summary>
        /// Gets the entity.
        /// </summary>
        /// <param name="id">The unique identifier.</param>
        /// <returns>The entity.</returns>
        TEntity Get(int id);

        /// <summary>
        /// Removes the entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Remove(TEntity entity);

        /// <summary>
        /// Removes the entity.
        /// </summary>
        /// <param name="id">The unique identifier.</param>
        void Remove(int id);

        /// <summary>
        /// Updates the entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>The entity.</returns>
        TEntity Update(TEntity entity);
    }
}
