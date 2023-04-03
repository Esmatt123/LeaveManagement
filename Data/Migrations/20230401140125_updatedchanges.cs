using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class updatedchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b11742de-236l-4845-4444-054d23kce48f",
                column: "ConcurrencyStamp",
                value: "c15ee4d1-e1db-4bbd-8984-5bd14c87880b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e97039da-ef08-42a8-b6fc-3949a78a0032",
                column: "ConcurrencyStamp",
                value: "531f1424-1585-4c01-bd95-612b27c14f02");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e97039db-ed07-42a6-b6fc-3849a78a0022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bdb98c6-4c29-4dc5-ac78-a549708624a8", "AQAAAAEAACcQAAAAENwkTpjoKfTMz1DfHFJvevmirn6r0OcY7SXv4Imsy+sXdJMte/+1s+veYM/F+Oi/LQ==", "103a062b-d129-480d-b1d5-3144d4a45d8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e97039dc-ef07-42a7-b6fd-3949a78a0022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7cc6be80-0312-436e-91b3-f043697b1b29", "AQAAAAEAACcQAAAAEAznbtb97JOsmMee41LEcMmZR5+baHVugJSgNx5/CwZjN7lV05XQ3pkEAEoSxdwaJQ==", "a159ba08-a31c-4bd5-84d4-61034c17f9eb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b11742de-236l-4845-4444-054d23kce48f",
                column: "ConcurrencyStamp",
                value: "85a6308f-58e5-4e53-8681-270b05e56344");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e97039da-ef08-42a8-b6fc-3949a78a0032",
                column: "ConcurrencyStamp",
                value: "07ecd73a-ffc5-4ac5-a080-a419779d613f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e97039db-ed07-42a6-b6fc-3849a78a0022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2c36ef1-9abd-4dd9-bce7-d30ab3867f98", "AQAAAAEAACcQAAAAEHq1vKx6j/5K3AxmdzKcqub8qB3nBPAwq9ZnjPONDbxD0GFOyzdwqnPPLZEDcgDDPQ==", "a1323a70-09bd-4ff4-a6b1-b5098b633a9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e97039dc-ef07-42a7-b6fd-3949a78a0022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74e42954-1761-43fe-b31d-a4ef345b357e", "AQAAAAEAACcQAAAAEPbA6A8fq7MoFaUwJ7UOFZ2taXcCBa/UxSDR39gsKuuJJveP7KVzf4yPToUu50A3uQ==", "283f9cec-6eb0-46cc-9908-9ddf679c0d7a" });
        }
    }
}
