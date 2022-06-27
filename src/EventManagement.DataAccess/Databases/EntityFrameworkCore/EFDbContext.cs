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

        public DbSet<Country> Countries { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<Organizer> Organizers { get; set; }

        public DbSet<Speaker> Speakers { get; set; }

        public DbSet<Street> Streets { get; set; }

        public DbSet<Town> Towns { get; set; }

        public DbSet<Venue> Venues { get; set; }

        #endregion
    }
}