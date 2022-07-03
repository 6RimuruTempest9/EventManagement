using EventManagement.DataAccess.Databases.EntityFrameworkCore;
using EventManagement.DataAccess.Entities;
using EventManagement.DataAccess.Repositories;
using EventManagement.DataAccess.Repositories.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EventManagement.DataAccess.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void AddEFDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<EFDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
        }

        public static void AddEFRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryAsync<Event>, EFEventRepository>();
        }
    }
}