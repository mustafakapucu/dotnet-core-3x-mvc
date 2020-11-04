using AspNetCore.Core;
using AspNetCore.Core.Repositories;
using AspNetCore.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AspNetCoreDbContext _context;
        private UserRepository _userRepository;
        private RoleRepository _roleRepository;
        private UserRoleRepository _userRoleRepository;

        public UnitOfWork(AspNetCoreDbContext context)
        {
            this._context = context;
        }

        public IUserRepository Users => _userRepository = _userRepository ?? new UserRepository(_context);
        public IRoleRepository Roles => _roleRepository = _roleRepository ?? new RoleRepository(_context);
        public IUserRoleRepository UserRoles => _userRoleRepository = _userRoleRepository ?? new UserRoleRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
