using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CodePulse.API.Data
{
    public class AuthDbContext : IdentityDbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);

        //    var readerRoleId = "53e56370-ce73-4218-998c-4d33ae021d57";
        //    var writerRoleId = "ff26077f-1767-464e-9513-de062372cabb";
        //    var roles = new List<IdentityRole>
        //    {
        //        new IdentityRole
        //        {
        //            Id = readerRoleId,
        //            Name = "Reader",
        //            NormalizedName="Reader".ToUpper(),
        //            ConcurrencyStamp=readerRoleId
        //        },

        //        new IdentityRole
        //        {
        //            Id=writerRoleId,
        //            Name= "Writer",
        //            NormalizedName="Writer".ToUpper(),
        //            ConcurrencyStamp=writerRoleId
        //        }
        //    };

        //    builder.Entity<IdentityRole>().HasData(roles);

        //    var adminUserId = "900e7e0e-6f3a-427a-9f21-68466d59b68f";
        //    var admin = new IdentityUser()
        //    {
        //        Id = adminUserId,
        //        UserName = "admin@codepulse.com",
        //        Email = "admin@codepulse.com",
        //        NormalizedEmail = "admin@codepulse.com".ToUpper(),
        //        NormalizedUserName = "admin@codepulse.com".ToUpper()
        //    };

        //    admin.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(admin, "Admin@123");

        //    builder.Entity<IdentityUser>().HasData(admin);

        //    var adminRoles = new List<IdentityUserRole<string>>()
        //    {
        //        new()
        //        {
        //            UserId = adminUserId,
        //            RoleId = readerRoleId
        //        },
        //        new()
        //        {
        //            UserId = adminUserId,
        //            RoleId = writerRoleId
        //        }
        //    };

        //    builder.Entity<IdentityUserRole<string>>().HasData(adminRoles);
        //}
    }
}
