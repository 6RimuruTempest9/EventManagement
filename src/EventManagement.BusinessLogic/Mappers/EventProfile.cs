using AutoMapper;
using EventManagement.BusinessLogic.DataTransferObjects;
using EventManagement.DataAccess.Entities;

namespace EventManagement.BusinessLogic.Mappers
{
    internal class EventProfile : Profile
    {
        #region Constructors

        public EventProfile()
        {
            CreateMap<Event, EventDto>().ReverseMap();
        }

        #endregion
    }
}