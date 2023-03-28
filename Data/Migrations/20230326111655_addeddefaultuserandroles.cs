using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class addeddefaultuserandroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "333c372d-aeb6-48f6-8d39-864c790e0eff",
                column: "ConcurrencyStamp",
                value: "cecf17d2-0fab-4f9a-b005-768b00743e74");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b01742de-235l-4835-8444-054c23kce48f",
                column: "ConcurrencyStamp",
                value: "72882635-e109-44c8-9f3c-5a299e5ebf53");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e97039db-ed07-42a6-b6fc-3849a78a0022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4342440a-7156-4b84-866f-82fdb4398a9c", "AQAAAAEAACcQAAAAEBd8RP4F3NmAvxy74aDpBOfHNg4u1/ldrpefzmwp9MIM/m05C8bjUtiEuoZUXzVgnQ==", "bdb27283-42b1-4cf7-8b4a-8e99caace601", "user@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "333c372d-aeb6-48f6-8d39-864c790e0eff",
                column: "ConcurrencyStamp",
                value: "9b1433a0-c934-4bb1-8a36-60eb0ce9683c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b01742de-235l-4835-8444-054c23kce48f",
                column: "ConcurrencyStamp",
                value: "cb142e81-47d6-411e-9ede-7d54535263d9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e97039db-ed07-42a6-b6fc-3849a78a0022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bc633131-1b74-4c25-8924-b1b6f374ff33", "AQAAAAEAACcQAAAAEJspfHAV6UU2sRjt9fDagGYHrVXDnETpUoT/FwyKZ0/PtxygSko0+Z34KldC9KBVRQ==", "f084c7a3-8f50-4e53-9139-b794f8c818dc", null });
        }
    }
}
