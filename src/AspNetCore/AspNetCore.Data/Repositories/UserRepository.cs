using AspNetCore.Core.Models;
using AspNetCore.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AspNetCoreDbContext context)
            : base(context)
        { }

        public async Task<IEnumerable<User>> GetAllWithRolesAsync()
        {
            return await AspNetCoreDbContext.Users
                .Include(a => a.UserRoles)
                .ToListAsync();
        }

        public Task<User> GetWithRolesByIdAsync(int id)
        {
            return AspNetCoreDbContext.Users
              .Include(a => a.UserRoles)
              .SingleOrDefaultAsync(a => a.Id == id);
        }

        private AspNetCoreDbContext AspNetCoreDbContext
        {
            get { return Context as AspNetCoreDbContext; }
        }
    }
}
