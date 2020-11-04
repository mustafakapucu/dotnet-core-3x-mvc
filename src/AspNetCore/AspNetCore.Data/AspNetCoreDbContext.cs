using AspNetCore.Core.Models;
using AspNetCore.Data.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Data
{
    public class AspNetCoreDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        public AspNetCoreDbContext(DbContextOptions<AspNetCoreDbContext> options)
          : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration(new UserConfiguration());

            builder
                .ApplyConfiguration(new RoleConfiguration());

            builder
                .ApplyConfiguration(new UserRoleConfiguration());
        }

    }
}
