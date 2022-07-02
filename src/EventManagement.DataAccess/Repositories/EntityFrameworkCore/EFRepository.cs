using EventManagement.DataAccess.Databases.EntityFrameworkCore;
using EventManagement.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventManagement.DataAccess.Repositories.EntityFrameworkCore
{
    internal class EFRepository<TEntity> : IRepositoryAsync<TEntity>
        where TEntity : Entity
    {
        #region Fields

        private readonly EFDbContext _context;

        private readonly DbSet<TEntity> _entities;

        #endregion

        #region Constructors

        public EFRepository(EFDbContext context)
        {
            _context = context;

            _entities = context.Set<TEntity>();
        }

        #endregion

        #region Methods

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);

            _entities.Remove(entity);

            await _context.SaveChangesAsync();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _entities.AsQueryable();
        }

        public Task<TEntity> GetByIdAsync(int id)
        {
            return _entities.FirstAsync(entity => entity.Id == id);
        }

        public Task InsertAsync(TEntity entity)
        {
            _entities.Add(entity);

            return _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            var updatingEntity = await _entities.FirstAsync(currentEntity => currentEntity.Id == entity.Id);

            _context.Entry(updatingEntity).CurrentValues.SetValues(entity);

            await _context.SaveChangesAsync();
        }

        #endregion
    }
}