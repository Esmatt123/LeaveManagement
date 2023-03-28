using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class hopeitwurks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b01742de-235l-4835-8444-054c23kce48f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e97039dc-ef07-42a7-b6fd-3949a78a0022", "e97039db-ed07-42a6-b6fc-3849a78a0022" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e97039dc-ef07-42a7-b6fd-3949a78a0022");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b11742de-236l-4845-4444-054d23kce48f", "729cc0cd-cb6e-4e58-87d2-9f6169e01da4", "User", "USER" },
                    { "e97039da-ef08-42a8-b6fc-3949a78a0032", "5a11233f-5be0-4f0b-a5ef-b123b8d93f16", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e97039db-ed07-42a6-b6fc-3849a78a0022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd181cd2-d7df-45f7-9d38-4d2bc1d6fe45", "AQAAAAEAACcQAAAAEPJAdZCfhwk5QEmrs6c9TLcmIffD7E9S8WT19004QbZvUog3FEQ5l6Gth9I9QwuTxw==", "2a11857e-e9de-48b6-90ed-44dd6b121e1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e97039dc-ef07-42a7-b6fd-3949a78a0022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d97c440-c547-4d84-865d-8cf86e43ef05", "AQAAAAEAACcQAAAAEOxbay3z8XexCkimIlqRPZEUD56hKTU/8EYQpB+zk2V3aO/9TXk5uxv5Zk3c+JgL0w==", "3f3cbf91-f1f9-4e13-af1b-46200967658d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b11742de-236l-4845-4444-054d23kce48f", "e97039db-ed07-42a6-b6fc-3849a78a0022" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e97039da-ef08-42a8-b6fc-3949a78a0032", "e97039dc-ef07-42a7-b6fd-3949a78a0022" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b11742de-236l-4845-4444-054d23kce48f", "e97039db-ed07-42a6-b6fc-3849a78a0022" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e97039da-ef08-42a8-b6fc-3949a78a0032", "e97039dc-ef07-42a7-b6fd-3949a78a0022" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b11742de-236l-4845-4444-054d23kce48f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e97039da-ef08-42a8-b6fc-3949a78a0032");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b01742de-235l-4835-8444-054c23kce48f", "912b85b5-b86a-468f-ac29-d32677085ac5", "User", "USER" },
                    { "e97039dc-ef07-42a7-b6fd-3949a78a0022", "55081e01-79f4-4892-a923-daa040ef1d5a", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e97039db-ed07-42a6-b6fc-3849a78a0022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8caffb4-de9c-466e-bb18-7b1e9a6dfabb", "AQAAAAEAACcQAAAAEE9TxH4cHC93QXgxa1fD5VLRM99qwKely9PsQQva5uVfYULt8zPVwFA5JGUVouBtRw==", "dd42caae-e403-4c50-b2a9-bf88e8c72aee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e97039dc-ef07-42a7-b6fd-3949a78a0022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08bf8ac7-b365-43b2-b1b9-e2dd536aea3c", "AQAAAAEAACcQAAAAECY0h1rNbiw4SFRYaPbx9YsJ5VjPUJPQowv3fSzwF6a8OGzBMvgu/ErCwdC4rW3Ixw==", "bbb115e1-6721-4156-ae16-ed474756cfd4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e97039dc-ef07-42a7-b6fd-3949a78a0022", "e97039db-ed07-42a6-b6fc-3849a78a0022" });
        }
    }
}
