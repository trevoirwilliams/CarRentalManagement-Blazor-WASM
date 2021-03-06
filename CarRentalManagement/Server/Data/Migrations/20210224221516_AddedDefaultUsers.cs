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
                value: "699f95e7-c95f-43d6-b331-b3c4282f71cc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "c52ec313-730c-4712-b0d3-ddb0926dcb45");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "c3143f50-3e14-403c-8d46-0af5cf35d52a", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEF3hU1JNOhHqBJcNHpZzJEY6+qRxvyivmQ1xbfpBxT2QWQShE3/Az50Fqy9I2r6dzQ==", null, false, "20c95e77-a3c8-4463-8a3b-34ecce26f4ef", false, "admin@localhost.com" },
                    { "9e224968-33e4-4652-b7b7-8574d048cdb9", 0, "6644dced-5622-4cf2-9cf4-56cb0ac4042b", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEAr8lPUkW6KADtIh1qqT750pD5NSnWCLTJvBe49PcF78xQsnXm5pLr2iBaq9SzZ+jg==", null, false, "d016df0b-1358-4e05-a17e-1522db137652", false, "user@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 24, 17, 15, 15, 753, DateTimeKind.Local).AddTicks(3748), new DateTime(2021, 2, 24, 17, 15, 15, 754, DateTimeKind.Local).AddTicks(2134) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 24, 17, 15, 15, 754, DateTimeKind.Local).AddTicks(3531), new DateTime(2021, 2, 24, 17, 15, 15, 754, DateTimeKind.Local).AddTicks(3536) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 24, 17, 15, 15, 755, DateTimeKind.Local).AddTicks(6145), new DateTime(2021, 2, 24, 17, 15, 15, 755, DateTimeKind.Local).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 24, 17, 15, 15, 755, DateTimeKind.Local).AddTicks(6640), new DateTime(2021, 2, 24, 17, 15, 15, 755, DateTimeKind.Local).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 24, 17, 15, 15, 756, DateTimeKind.Local).AddTicks(132), new DateTime(2021, 2, 24, 17, 15, 15, 756, DateTimeKind.Local).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 24, 17, 15, 15, 756, DateTimeKind.Local).AddTicks(617), new DateTime(2021, 2, 24, 17, 15, 15, 756, DateTimeKind.Local).AddTicks(621) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 24, 17, 15, 15, 756, DateTimeKind.Local).AddTicks(622), new DateTime(2021, 2, 24, 17, 15, 15, 756, DateTimeKind.Local).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 2, 24, 17, 15, 15, 756, DateTimeKind.Local).AddTicks(625), new DateTime(2021, 2, 24, 17, 15, 15, 756, DateTimeKind.Local).AddTicks(626) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9");

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
