using AspNetCore.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Core.Services
{
    public interface IRoleService
    {
        Task<IEnumerable<Role>> GetAllWithUser();
        Task<Role> GetRoleById(int id);
        Task<IEnumerable<Role>> GetRolesByUserId(int userId);
        Task<Role> CreateRole(Role newRole);
        Task UpdateRole(Role roleToBeUpdated, Role role);
        Task DeleteRole(Role role);
    }
}
