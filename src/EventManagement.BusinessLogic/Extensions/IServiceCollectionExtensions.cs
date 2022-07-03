using EventManagement.BusinessLogic.DataTransferObjects;
using EventManagement.BusinessLogic.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EventManagement.BusinessLogic.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IServiceAsync<EventDto>, EventService>();
        }
    }
}