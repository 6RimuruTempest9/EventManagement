using AutoMapper;
using EventManagement.API.Models;
using EventManagement.BusinessLogic.DataTransferObjects;
using EventManagement.BusinessLogic.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EventManagement.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class EventController : Controller
    {
        #region Fields

        private readonly IServiceAsync<EventDto> _eventService;
        private readonly IMapper _mapper;

        #endregion

        #region Constructors

        public EventController(
            IServiceAsync<EventDto> eventService,
            IMapper mapper)
        {
            _eventService = eventService;
            _mapper = mapper;
        }

        #endregion

        #region Methods

        [HttpGet]
        [Route("[action]")]
        public async Task<IEnumerable<Event>> GetAll()
        {
            return await _eventService
                .GetAll()
                .Select(eventDto => _mapper.Map<Event>(eventDto))
                .ToListAsync();
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<Event> GetById(int id)
        {
            var eventDto = await _eventService.GetByIdAsync(id);

            return _mapper.Map<Event>(eventDto);
        }

        [HttpPost]
        [Route("[action]/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _eventService.DeleteAsync(id);

            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Update([FromBody] Event @event)
        {
            var eventDto = _mapper.Map<EventDto>(@event);

            await _eventService.UpdateAsync(eventDto);

            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Insert([FromBody] Event @event)
        {
            var eventDto = _mapper.Map<EventDto>(@event);

            await _eventService.InsertAsync(eventDto);

            return Ok();
        }

        #endregion
    }
}