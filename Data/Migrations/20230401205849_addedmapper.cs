using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class addedmapper : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b11742de-236l-4845-4444-054d23kce48f",
                column: "ConcurrencyStamp",
                value: "3da308da-fc96-4c3b-a932-33771e156c44");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e97039da-ef08-42a8-b6fc-3949a78a0032",
                column: "ConcurrencyStamp",
                value: "42422910-9e9b-409f-8145-09db70372280");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e97039db-ed07-42a6-b6fc-3849a78a0022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af4e909f-0f65-40ef-9603-52173af255ea", "AQAAAAEAACcQAAAAEDTa721pscrw21MNPBxGiRDg2s3spNn9dKF9qbwhU0iyKkvw5QXHdttfCzW7jeMrzA==", "f4baf28d-5500-4902-aa4f-9f2c18b40fb4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e97039dc-ef07-42a7-b6fd-3949a78a0022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fca99922-57cb-436b-8e7a-69da30dc1940", "AQAAAAEAACcQAAAAEC8iGEKhjmbQCCC7v3tD2YzclXNZgHsLLR8DM6SCzbP7tictlExN6ChXgH5S+ODRMA==", "91a34450-b8c0-48e6-8684-a91176a2350e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b11742de-236l-4845-4444-054d23kce48f",
                column: "ConcurrencyStamp",
                value: "5180653f-1007-45eb-93ff-8ca61db8f415");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e97039da-ef08-42a8-b6fc-3949a78a0032",
                column: "ConcurrencyStamp",
                value: "7ad7d709-7a7a-414c-96b6-bb0355f2850e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e97039db-ed07-42a6-b6fc-3849a78a0022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1c76dfa-3fe9-492b-a6ba-cbcf62f4a924", "AQAAAAEAACcQAAAAEHCtkHCkvmSEnFVRpHea62+QykW2vAs/yo9xxLN5n+1yYB/BYnnvxjicwx2gYE3ZNg==", "7322fbb9-00a8-46ee-b7d4-8079df28a5d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e97039dc-ef07-42a7-b6fd-3949a78a0022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dee190ca-054e-4486-9098-08ebfb1b2411", "AQAAAAEAACcQAAAAEH3Vzx97WcHN9fjjAn5Vjvj263mmAmdcsnbvQlKftsFgXwE0gp4LsmlrpxPLVHAfkA==", "e493e355-e43e-4987-9ada-683634929b42" });
        }
    }
}
