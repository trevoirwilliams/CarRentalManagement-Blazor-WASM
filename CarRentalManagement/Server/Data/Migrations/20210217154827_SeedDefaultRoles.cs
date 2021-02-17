using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "030b8408-4734-429f-a6e9-706d86b845f3", "User", "USER" },
                    { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "7fce9e69-19d6-4239-bac0-60f7796bdc7b", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 17, 10, 48, 27, 502, DateTimeKind.Local).AddTicks(3652), new DateTime(2021, 2, 17, 10, 48, 27, 503, DateTimeKind.Local).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 17, 10, 48, 27, 503, DateTimeKind.Local).AddTicks(3191), new DateTime(2021, 2, 17, 10, 48, 27, 503, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 17, 10, 48, 27, 504, DateTimeKind.Local).AddTicks(6563), new DateTime(2021, 2, 17, 10, 48, 27, 504, DateTimeKind.Local).AddTicks(6575) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 17, 10, 48, 27, 504, DateTimeKind.Local).AddTicks(7034), new DateTime(2021, 2, 17, 10, 48, 27, 504, DateTimeKind.Local).AddTicks(7038) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 17, 10, 48, 27, 505, DateTimeKind.Local).AddTicks(502), new DateTime(2021, 2, 17, 10, 48, 27, 505, DateTimeKind.Local).AddTicks(507) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 17, 10, 48, 27, 505, DateTimeKind.Local).AddTicks(965), new DateTime(2021, 2, 17, 10, 48, 27, 505, DateTimeKind.Local).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 17, 10, 48, 27, 505, DateTimeKind.Local).AddTicks(1020), new DateTime(2021, 2, 17, 10, 48, 27, 505, DateTimeKind.Local).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 17, 10, 48, 27, 505, DateTimeKind.Local).AddTicks(1023), new DateTime(2021, 2, 17, 10, 48, 27, 505, DateTimeKind.Local).AddTicks(1024) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 17, 10, 41, 20, 696, DateTimeKind.Local).AddTicks(1986), new DateTime(2021, 2, 17, 10, 41, 20, 696, DateTimeKind.Local).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 17, 10, 41, 20, 697, DateTimeKind.Local).AddTicks(1162), new DateTime(2021, 2, 17, 10, 41, 20, 697, DateTimeKind.Local).AddTicks(1167) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 17, 10, 41, 20, 698, DateTimeKind.Local).AddTicks(2992), new DateTime(2021, 2, 17, 10, 41, 20, 698, DateTimeKind.Local).AddTicks(2999) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 17, 10, 41, 20, 698, DateTimeKind.Local).AddTicks(3451), new DateTime(2021, 2, 17, 10, 41, 20, 698, DateTimeKind.Local).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 17, 10, 41, 20, 698, DateTimeKind.Local).AddTicks(6888), new DateTime(2021, 2, 17, 10, 41, 20, 698, DateTimeKind.Local).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 17, 10, 41, 20, 698, DateTimeKind.Local).AddTicks(7345), new DateTime(2021, 2, 17, 10, 41, 20, 698, DateTimeKind.Local).AddTicks(7348) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 17, 10, 41, 20, 698, DateTimeKind.Local).AddTicks(7350), new DateTime(2021, 2, 17, 10, 41, 20, 698, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 17, 10, 41, 20, 698, DateTimeKind.Local).AddTicks(7352), new DateTime(2021, 2, 17, 10, 41, 20, 698, DateTimeKind.Local).AddTicks(7353) });
        }
    }
}
