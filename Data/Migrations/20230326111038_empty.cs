using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class empty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "333c372d-aeb6-48f6-8d39-864c790e0eff", "9b1433a0-c934-4bb1-8a36-60eb0ce9683c", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b01742de-235l-4835-8444-054c23kce48f", "cb142e81-47d6-411e-9ede-7d54535263d9", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e97039db-ed07-42a6-b6fc-3849a78a0022", 0, "bc633131-1b74-4c25-8924-b1b6f374ff33", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "system", "user", false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEJspfHAV6UU2sRjt9fDagGYHrVXDnETpUoT/FwyKZ0/PtxygSko0+Z34KldC9KBVRQ==", null, false, "f084c7a3-8f50-4e53-9139-b794f8c818dc", null, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "333c372d-aeb6-48f6-8d39-864c790e0eff", "e97039db-ed07-42a6-b6fc-3849a78a0022" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b01742de-235l-4835-8444-054c23kce48f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "333c372d-aeb6-48f6-8d39-864c790e0eff", "e97039db-ed07-42a6-b6fc-3849a78a0022" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "333c372d-aeb6-48f6-8d39-864c790e0eff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e97039db-ed07-42a6-b6fc-3849a78a0022");
        }
    }
}
