using AspNetCore.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Core.Repositories
{
    public interface IRoleRepository : IRepository<Role>
    {
        //Task<IEnumerable<Role>> GetAllWithUserAsync();
        //Task<Role> GetWithUserByIdAsync(int id);
        //Task<IEnumerable<Role>> GetAllWithUserByUserIdAsync(int userId);
    }
}
