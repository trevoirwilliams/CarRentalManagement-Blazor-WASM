using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 2, 17, 10, 41, 20, 696, DateTimeKind.Local).AddTicks(1986), new DateTime(2021, 2, 17, 10, 41, 20, 696, DateTimeKind.Local).AddTicks(9870), "Black", "System" },
                    { 2, "System", new DateTime(2021, 2, 17, 10, 41, 20, 697, DateTimeKind.Local).AddTicks(1162), new DateTime(2021, 2, 17, 10, 41, 20, 697, DateTimeKind.Local).AddTicks(1167), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 2, 17, 10, 41, 20, 698, DateTimeKind.Local).AddTicks(2992), new DateTime(2021, 2, 17, 10, 41, 20, 698, DateTimeKind.Local).AddTicks(2999), "Toyota", "System" },
                    { 2, "System", new DateTime(2021, 2, 17, 10, 41, 20, 698, DateTimeKind.Local).AddTicks(3451), new DateTime(2021, 2, 17, 10, 41, 20, 698, DateTimeKind.Local).AddTicks(3455), "BMW", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 2, 17, 10, 41, 20, 698, DateTimeKind.Local).AddTicks(6888), new DateTime(2021, 2, 17, 10, 41, 20, 698, DateTimeKind.Local).AddTicks(6895), "Prius", "System" },
                    { 2, "System", new DateTime(2021, 2, 17, 10, 41, 20, 698, DateTimeKind.Local).AddTicks(7345), new DateTime(2021, 2, 17, 10, 41, 20, 698, DateTimeKind.Local).AddTicks(7348), "Vitz", "System" },
                    { 3, "System", new DateTime(2021, 2, 17, 10, 41, 20, 698, DateTimeKind.Local).AddTicks(7350), new DateTime(2021, 2, 17, 10, 41, 20, 698, DateTimeKind.Local).AddTicks(7351), "3 Series", "System" },
                    { 4, "System", new DateTime(2021, 2, 17, 10, 41, 20, 698, DateTimeKind.Local).AddTicks(7352), new DateTime(2021, 2, 17, 10, 41, 20, 698, DateTimeKind.Local).AddTicks(7353), "X5", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
