using AutoMapper;
using EventManagement.API.Models;
using EventManagement.BusinessLogic.DataTransferObjects;

namespace EventManagement.API.Mappers
{
    internal class EventProfile : Profile
    {
        #region Constructors

        public EventProfile()
        {
            CreateMap<EventDto, Event>().ReverseMap();
        }

        #endregion
    }
}