using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AspNetCore.Core.Models
{
    public class Role
    {
        public Role()
        {
            UserRoles = new Collection<UserRole>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
