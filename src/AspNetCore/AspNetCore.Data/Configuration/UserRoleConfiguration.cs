using AspNetCore.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNetCore.Data.Configuration
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).UseIdentityColumn();
            builder.Property(a => a.UserId).IsRequired();
            builder.Property(a => a.RoleId).IsRequired();
            builder.HasOne(a => a.Users).WithMany(a => a.UserRoles).HasForeignKey(a => a.UserId);
            builder.HasOne(a => a.Roles).WithMany(a => a.UserRoles).HasForeignKey(a => a.RoleId);
            builder.ToTable("UserRoles");
        }

    }
}
