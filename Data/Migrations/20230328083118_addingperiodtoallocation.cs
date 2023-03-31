using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class addingperiodtoallocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b11742de-236l-4845-4444-054d23kce48f",
                column: "ConcurrencyStamp",
                value: "d3c0e4e4-74db-483e-a244-6235a5852d2f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e97039da-ef08-42a8-b6fc-3949a78a0032",
                column: "ConcurrencyStamp",
                value: "99f5fd47-b9de-4595-94c2-99139e1b70f2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e97039db-ed07-42a6-b6fc-3849a78a0022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f590c5ae-f700-4191-8aae-21e18cdeede2", "AQAAAAEAACcQAAAAEArkR6coUQ/iE+nEbx41JjhgEkGmkO4hAKwA7uFJxK51JK2M6JTnfD2pckFaNE/Vfg==", "94b153df-82bd-474a-a731-ee40427ba8eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e97039dc-ef07-42a7-b6fd-3949a78a0022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5127826-c700-4994-ae9f-81e9fa5e70a9", "AQAAAAEAACcQAAAAEKsXMY1uo2s1J+WdMIpa23+cCVkpxLlCxeLP7GjbT7/qvHtG9kgcnc66vordCg4XtQ==", "a6cf1603-5d60-4be9-a415-d15b7c3a2ee1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b11742de-236l-4845-4444-054d23kce48f",
                column: "ConcurrencyStamp",
                value: "729cc0cd-cb6e-4e58-87d2-9f6169e01da4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e97039da-ef08-42a8-b6fc-3949a78a0032",
                column: "ConcurrencyStamp",
                value: "5a11233f-5be0-4f0b-a5ef-b123b8d93f16");

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
        }
    }
}
