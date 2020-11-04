using AspNetCore.Core.Models;
using AspNetCore.Core.Repositories;

namespace AspNetCore.Data.Repositories
{
    public class UserRoleRepository : Repository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(AspNetCoreDbContext context)
            : base(context)
        { }

        private AspNetCoreDbContext AspNetCoreDbContext
        {
            get { return Context as AspNetCoreDbContext; }
        }
    }
}
