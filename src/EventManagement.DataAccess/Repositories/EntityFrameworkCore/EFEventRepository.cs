using EventManagement.DataAccess.Databases.EntityFrameworkCore;
using EventManagement.DataAccess.Entities;

namespace EventManagement.DataAccess.Repositories.EntityFrameworkCore
{
    internal class EFEventRepository : EFRepository<Event>
    {
        #region Constructors

        public EFEventRepository(EFDbContext context)
            : base(context)
        {
        }

        #endregion
    }
}