using EventManagement.BusinessLogic.DataTransferObjects;

namespace EventManagement.BusinessLogic.Services
{
    public interface IServiceAsync<TDto>
        where TDto : IDto
    {
        public IQueryable<TDto> GetAll();

        public Task<TDto> GetByIdAsync(int id);

        public Task InsertAsync(TDto dto);

        public Task UpdateAsync(TDto dto);

        public Task DeleteAsync(int id);
    }
}