using EventManagement.DataAccess.Entities;

namespace EventManagement.DataAccess.Repositories
{
    public interface IRepositoryAsync<TEntity>
        where TEntity : IEntity
    {
        public IQueryable<TEntity> GetAll();

        public Task<TEntity> GetByIdAsync(int id);

        public Task InsertAsync(TEntity entity);

        public Task DeleteAsync(int id);

        public Task UpdateAsync(TEntity entity);
    }
}