using LeaveManagement.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Employee> builder)
    {
            var hasher = new PasswordHasher<Employee>();
        builder.HasData(
           
            new Employee
            {
                Id = "e97039db-ed07-42a6-b6fc-3849a78a0022",
                Email = "user@gmail.com",
                NormalizedEmail = "USER@GMAIL.COM",
                NormalizedUserName = "USER@GMAIL.COM",
                UserName = "user@gmail.com",
                Firstname = "system",
                Lastname = "user",
                PasswordHash = hasher.HashPassword(null, "Itsuser1!"),
                EmailConfirmed = true,
            },

             new Employee
             {
                 Id = "e97039dc-ef07-42a7-b6fd-3949a78a0022",
                 Email = "admin@gmail.com",
                 NormalizedEmail = "ADMIN@GMAIL.COM",
                 NormalizedUserName = "ADMIN@GMAIL.COM",
                 UserName = "admin@gmail.com",
                 Firstname = "system",
                 Lastname = "admin",
                 PasswordHash = hasher.HashPassword(null, "Itsadmin1!"),
                 EmailConfirmed = true,
             });
    }
}


    
}
