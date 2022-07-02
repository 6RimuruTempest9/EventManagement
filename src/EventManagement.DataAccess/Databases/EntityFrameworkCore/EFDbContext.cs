using EventManagement.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventManagement.DataAccess.Databases.EntityFrameworkCore
{
    internal class EFDbContext : DbContext
    {
        #region Constructors

        public EFDbContext(DbContextOptions<EFDbContext> options)
            : base(options)
        {
        }

        #endregion

        #region Properties

        public DbSet<Event> Events { get; set; }

        #endregion
    }
}