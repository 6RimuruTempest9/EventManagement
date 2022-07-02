using EventManagement.DataAccess.Entities;
using EventManagement.DataAccess.Repositories;
using EventManagement.DataAccess.Repositories.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EventManagement.DataAccess.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void AddEFRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryAsync<Event>, EFEventRepository>();
        }
    }
}