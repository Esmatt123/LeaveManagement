using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace LeaveManagement.Web.Configurations.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "b11742de-236l-4845-4444-054d23kce48f",
                    UserId = "e97039db-ed07-42a6-b6fc-3849a78a0022",
                },
                new IdentityUserRole<string>
                {
                    RoleId = "e97039da-ef08-42a8-b6fc-3949a78a0032",
                    UserId = "e97039dc-ef07-42a7-b6fd-3949a78a0022",
                }
                );
        }
    }
}