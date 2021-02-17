using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "39985315-1711-41e8-8dcd-c53bddec0b4e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "82723de6-3ad6-4ae2-b2c0-503d099082bc");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "3663306e-3d27-4179-9a81-d2f754889ec6", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEHhH32OR4lP38iTwoMuGLTHAmWDiy7fyfrxfYPREnvMgTCghKWifLbvCTbXt2Hs4Ug==", null, false, "ff0b4eb1-44df-41ba-8ca8-ce1cafe3fdf4", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 17, 11, 11, 8, 266, DateTimeKind.Local).AddTicks(1420), new DateTime(2021, 2, 17, 11, 11, 8, 266, DateTimeKind.Local).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 17, 11, 11, 8, 267, DateTimeKind.Local).AddTicks(685), new DateTime(2021, 2, 17, 11, 11, 8, 267, DateTimeKind.Local).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 17, 11, 11, 8, 268, DateTimeKind.Local).AddTicks(3528), new DateTime(2021, 2, 17, 11, 11, 8, 268, DateTimeKind.Local).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 17, 11, 11, 8, 268, DateTimeKind.Local).AddTicks(3993), new DateTime(2021, 2, 17, 11, 11, 8, 268, DateTimeKind.Local).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 17, 11, 11, 8, 268, DateTimeKind.Local).AddTicks(7346), new DateTime(2021, 2, 17, 11, 11, 8, 268, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 17, 11, 11, 8, 268, DateTimeKind.Local).AddTicks(7795), new DateTime(2021, 2, 17, 11, 11, 8, 268, DateTimeKind.Local).AddTicks(7799) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 17, 11, 11, 8, 268, DateTimeKind.Local).AddTicks(7800), new DateTime(2021, 2, 17, 11, 11, 8, 268, DateTimeKind.Local).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 17, 11, 11, 8, 268, DateTimeKind.Local).AddTicks(7803), new DateTime(2021, 2, 17, 11, 11, 8, 268, DateTimeKind.Local).AddTicks(7803) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "030b8408-4734-429f-a6e9-706d86b845f3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "7fce9e69-19d6-4239-bac0-60f7796bdc7b");

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
    }
}
