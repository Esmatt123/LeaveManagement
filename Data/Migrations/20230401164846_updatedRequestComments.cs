using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class updatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
