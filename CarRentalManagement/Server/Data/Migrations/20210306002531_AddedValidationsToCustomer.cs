using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedValidationsToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "e2fcb11a-a44a-4b9c-9ec7-b7cb38649d7c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "0b3cebea-05a6-4f11-b560-1cf72b6d9e97");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94951c5c-0257-4333-85de-b31330485517", "AQAAAAEAACcQAAAAEKWHvHCD0Mfjg7vW/LNStuAtX56pJiwMs7z1sLZBzGiRYz2iuPSVDXKbCLr4X7GX7Q==", "07eb8039-8627-4919-a8c3-b7b1d1420749" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eaf911cb-0faa-4428-8cb4-dbd6ab8d8994", "AQAAAAEAACcQAAAAEGtM2RqyzfXR/t/xshrVnTZSRTL0l+11sR3tdEXTdrJg0hxeoAgAXhQilDq9UNRJLw==", "b77a51b3-b696-424d-9f85-e185928af9de" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 3, 5, 19, 25, 30, 565, DateTimeKind.Local).AddTicks(4129), new DateTime(2021, 3, 5, 19, 25, 30, 566, DateTimeKind.Local).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 3, 5, 19, 25, 30, 566, DateTimeKind.Local).AddTicks(3769), new DateTime(2021, 3, 5, 19, 25, 30, 566, DateTimeKind.Local).AddTicks(3775) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 3, 5, 19, 25, 30, 567, DateTimeKind.Local).AddTicks(6728), new DateTime(2021, 3, 5, 19, 25, 30, 567, DateTimeKind.Local).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 3, 5, 19, 25, 30, 567, DateTimeKind.Local).AddTicks(7211), new DateTime(2021, 3, 5, 19, 25, 30, 567, DateTimeKind.Local).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 3, 5, 19, 25, 30, 568, DateTimeKind.Local).AddTicks(520), new DateTime(2021, 3, 5, 19, 25, 30, 568, DateTimeKind.Local).AddTicks(526) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 3, 5, 19, 25, 30, 568, DateTimeKind.Local).AddTicks(987), new DateTime(2021, 3, 5, 19, 25, 30, 568, DateTimeKind.Local).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 3, 5, 19, 25, 30, 568, DateTimeKind.Local).AddTicks(993), new DateTime(2021, 3, 5, 19, 25, 30, 568, DateTimeKind.Local).AddTicks(994) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 3, 5, 19, 25, 30, 568, DateTimeKind.Local).AddTicks(995), new DateTime(2021, 3, 5, 19, 25, 30, 568, DateTimeKind.Local).AddTicks(996) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
