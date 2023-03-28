using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class addedadmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "333c372d-aeb6-48f6-8d39-864c790e0eff", "e97039db-ed07-42a6-b6fc-3849a78a0022" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "333c372d-aeb6-48f6-8d39-864c790e0eff");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b01742de-235l-4835-8444-054c23kce48f",
                column: "ConcurrencyStamp",
                value: "912b85b5-b86a-468f-ac29-d32677085ac5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e97039dc-ef07-42a7-b6fd-3949a78a0022", "55081e01-79f4-4892-a923-daa040ef1d5a", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e97039db-ed07-42a6-b6fc-3849a78a0022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8caffb4-de9c-466e-bb18-7b1e9a6dfabb", "AQAAAAEAACcQAAAAEE9TxH4cHC93QXgxa1fD5VLRM99qwKely9PsQQva5uVfYULt8zPVwFA5JGUVouBtRw==", "dd42caae-e403-4c50-b2a9-bf88e8c72aee" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e97039dc-ef07-42a7-b6fd-3949a78a0022", 0, "08bf8ac7-b365-43b2-b1b9-e2dd536aea3c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "system", "admin", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAECY0h1rNbiw4SFRYaPbx9YsJ5VjPUJPQowv3fSzwF6a8OGzBMvgu/ErCwdC4rW3Ixw==", null, false, "bbb115e1-6721-4156-ae16-ed474756cfd4", null, false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e97039dc-ef07-42a7-b6fd-3949a78a0022", "e97039db-ed07-42a6-b6fc-3849a78a0022" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e97039dc-ef07-42a7-b6fd-3949a78a0022", "e97039db-ed07-42a6-b6fc-3849a78a0022" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e97039dc-ef07-42a7-b6fd-3949a78a0022");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e97039dc-ef07-42a7-b6fd-3949a78a0022");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b01742de-235l-4835-8444-054c23kce48f",
                column: "ConcurrencyStamp",
                value: "72882635-e109-44c8-9f3c-5a299e5ebf53");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "333c372d-aeb6-48f6-8d39-864c790e0eff", "cecf17d2-0fab-4f9a-b005-768b00743e74", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e97039db-ed07-42a6-b6fc-3849a78a0022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4342440a-7156-4b84-866f-82fdb4398a9c", "AQAAAAEAACcQAAAAEBd8RP4F3NmAvxy74aDpBOfHNg4u1/ldrpefzmwp9MIM/m05C8bjUtiEuoZUXzVgnQ==", "bdb27283-42b1-4cf7-8b4a-8e99caace601" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "333c372d-aeb6-48f6-8d39-864c790e0eff", "e97039db-ed07-42a6-b6fc-3849a78a0022" });
        }
    }
}
