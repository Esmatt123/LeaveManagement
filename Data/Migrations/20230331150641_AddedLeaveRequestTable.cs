using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
