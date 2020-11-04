using AspNetCore.Core.Models;
using AspNetCore.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Data.Repositories
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(AspNetCoreDbContext context)
            : base(context)
        { }

        private AspNetCoreDbContext AspNetCoreDbContext
        {
            get { return Context as AspNetCoreDbContext; }
        }
    }
}
