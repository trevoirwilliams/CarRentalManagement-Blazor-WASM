using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedCustomerFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "b60ea13b-a336-4048-bbb8-cd48bed420cc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "4d8bf7e3-b422-4ea9-9b3c-f670f805d335");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1187616c-4331-48c2-a981-b185ced39bc1", "AQAAAAEAACcQAAAAEHSV+uDE0mgLN9Lf4VDMKSGOgEgoSVPP9VSYp1IAUo2uRv6NTdJjt2a8CbSPaPFgXg==", "328ba413-3928-48b5-9598-a219c6c825ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5060acd-7187-47c6-9f45-6db8005a612e", "AQAAAAEAACcQAAAAEN0E5oFAE/SQBoxiLhfFtOXKrRNww56mRt5XD4ACZUesx5rQuZvL3Tfy/hW+Bxsr9w==", "fb96f8d8-6969-4ed6-8878-640475c8a696" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 3, 5, 19, 16, 3, 674, DateTimeKind.Local).AddTicks(1063), new DateTime(2021, 3, 5, 19, 16, 3, 674, DateTimeKind.Local).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 3, 5, 19, 16, 3, 675, DateTimeKind.Local).AddTicks(1729), new DateTime(2021, 3, 5, 19, 16, 3, 675, DateTimeKind.Local).AddTicks(1734) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 3, 5, 19, 16, 3, 676, DateTimeKind.Local).AddTicks(4278), new DateTime(2021, 3, 5, 19, 16, 3, 676, DateTimeKind.Local).AddTicks(4287) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 3, 5, 19, 16, 3, 676, DateTimeKind.Local).AddTicks(4798), new DateTime(2021, 3, 5, 19, 16, 3, 676, DateTimeKind.Local).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 3, 5, 19, 16, 3, 676, DateTimeKind.Local).AddTicks(8179), new DateTime(2021, 3, 5, 19, 16, 3, 676, DateTimeKind.Local).AddTicks(8185) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 3, 5, 19, 16, 3, 676, DateTimeKind.Local).AddTicks(8639), new DateTime(2021, 3, 5, 19, 16, 3, 676, DateTimeKind.Local).AddTicks(8642) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 3, 5, 19, 16, 3, 676, DateTimeKind.Local).AddTicks(8644), new DateTime(2021, 3, 5, 19, 16, 3, 676, DateTimeKind.Local).AddTicks(8645) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 3, 5, 19, 16, 3, 676, DateTimeKind.Local).AddTicks(8646), new DateTime(2021, 3, 5, 19, 16, 3, 676, DateTimeKind.Local).AddTicks(8647) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3143f50-3e14-403c-8d46-0af5cf35d52a", "AQAAAAEAACcQAAAAEF3hU1JNOhHqBJcNHpZzJEY6+qRxvyivmQ1xbfpBxT2QWQShE3/Az50Fqy9I2r6dzQ==", "20c95e77-a3c8-4463-8a3b-34ecce26f4ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6644dced-5622-4cf2-9cf4-56cb0ac4042b", "AQAAAAEAACcQAAAAEAr8lPUkW6KADtIh1qqT750pD5NSnWCLTJvBe49PcF78xQsnXm5pLr2iBaq9SzZ+jg==", "d016df0b-1358-4e05-a17e-1522db137652" });

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
        }
    }
}
