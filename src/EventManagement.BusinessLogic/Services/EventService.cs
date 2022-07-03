using AutoMapper;
using EventManagement.BusinessLogic.DataTransferObjects;
using EventManagement.DataAccess.Entities;
using EventManagement.DataAccess.Repositories;

namespace EventManagement.BusinessLogic.Services
{
    internal class EventService : IServiceAsync<EventDto>
    {
        #region Fields

        private readonly IRepositoryAsync<Event> _eventRepository;
        private readonly IMapper _mapper;

        #endregion

        #region Constructors

        public EventService(IRepositoryAsync<Event> eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository ?? throw new ArgumentNullException(nameof(eventRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        #endregion

        #region Methods

        public Task DeleteAsync(int id)
        {
            return _eventRepository.DeleteAsync(id);
        }

        public IQueryable<EventDto> GetAll()
        {
            return _eventRepository
                .GetAll()
                .Select(@event => _mapper.Map<EventDto>(@event));
        }

        public async Task<EventDto> GetByIdAsync(int id)
        {
            var @event = await _eventRepository.GetByIdAsync(id);

            var eventDto = _mapper.Map<EventDto>(@event);
            
            return eventDto;
        }

        public Task InsertAsync(EventDto dto)
        {
            var @event = _mapper.Map<Event>(dto);

            return _eventRepository.InsertAsync(@event);
        }

        public Task UpdateAsync(EventDto dto)
        {
            var @event = _mapper.Map<Event>(dto);

            return _eventRepository.UpdateAsync(@event);
        }

        #endregion
    }
}