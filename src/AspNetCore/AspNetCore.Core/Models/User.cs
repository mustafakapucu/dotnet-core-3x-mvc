using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AspNetCore.Core.Models
{
    public class User
    {
        public User()
        {
            UserRoles = new Collection<UserRole>();
        }
        public int Id { get; set; }
        public string Username { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
