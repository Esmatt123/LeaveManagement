using LeaveManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Data
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
            {
                Id = "e97039da-ef08-42a8-b6fc-3949a78a0032",
                Name = Roles.Administrator,
                NormalizedName = Roles.Administrator.ToUpper(),

            }, 
                new IdentityRole
            {
                Id = "b11742de-236l-4845-4444-054d23kce48f",
                Name = Roles.User,
                NormalizedName = Roles.User.ToUpper(),
            });
        }
    }
}
