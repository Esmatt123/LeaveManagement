using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveRequest_LeaveTypes_LeaveTypeId",
                table: "LeaveRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeaveRequest",
                table: "LeaveRequest");

            migrationBuilder.RenameTable(
                name: "LeaveRequest",
                newName: "LeaveRequests");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveRequest_LeaveTypeId",
                table: "LeaveRequests",
                newName: "IX_LeaveRequests_LeaveTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeaveRequests",
                table: "LeaveRequests",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b11742de-236l-4845-4444-054d23kce48f",
                column: "ConcurrencyStamp",
                value: "ae01fab5-dc8b-4b69-b5ea-5bf2f4d487fb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e97039da-ef08-42a8-b6fc-3949a78a0032",
                column: "ConcurrencyStamp",
                value: "2fa83c81-5f92-400a-a6b3-f8bef95df59d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e97039db-ed07-42a6-b6fc-3849a78a0022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64f60618-31b4-4a2a-a771-2ed94a326602", "AQAAAAEAACcQAAAAEAcDmZU5m45KzqcRQsPDjkzJvBDFk/kT/4zXcXrsLDki3SKGlklEx2nHECHxVvQcfw==", "85c5fd90-add7-4656-b507-13fb4945019c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e97039dc-ef07-42a7-b6fd-3949a78a0022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3b15c83-4a3d-4978-8132-a031e1350bb2", "AQAAAAEAACcQAAAAEK0l13HSDfKwnxMOKqkanhvB304hlag0ZRc4o6iMCLvjA23KsjfS4bWEgOG2uz1Ozg==", "00200759-ef32-42e7-b52e-6e962cf6fc63" });

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId",
                principalTable: "LeaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                table: "LeaveRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeaveRequests",
                table: "LeaveRequests");

            migrationBuilder.RenameTable(
                name: "LeaveRequests",
                newName: "LeaveRequest");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequest",
                newName: "IX_LeaveRequest_LeaveTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeaveRequest",
                table: "LeaveRequest",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b11742de-236l-4845-4444-054d23kce48f",
                column: "ConcurrencyStamp",
                value: "d5700506-ca1b-4ac4-ab9b-ec90af7c77de");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e97039da-ef08-42a8-b6fc-3949a78a0032",
                column: "ConcurrencyStamp",
                value: "5925587a-3a70-4442-931c-23aad8b4f2bf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e97039db-ed07-42a6-b6fc-3849a78a0022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ec79c9d-9c35-4d88-840d-f6b7f836cb60", "AQAAAAEAACcQAAAAEEYUb6avDtIUf3P462C83CIvyklmJ8YHK400FM6GYKsZcDfz17n61n8Jmr+7MoBWdA==", "fd8f9d39-0e0a-4f98-be08-da657c4b3dfa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e97039dc-ef07-42a7-b6fd-3949a78a0022",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6f3f79d-40d9-42ae-a771-2c9fe42ddd1b", "AQAAAAEAACcQAAAAENnNhez7Avy5voxRazVU0Du87HhLpqj5xIDGDmedh5uXKrUtXw6YXxfqMgr20JbGow==", "6893404a-7e49-4df7-a423-a6942d3ef796" });

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveRequest_LeaveTypes_LeaveTypeId",
                table: "LeaveRequest",
                column: "LeaveTypeId",
                principalTable: "LeaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
