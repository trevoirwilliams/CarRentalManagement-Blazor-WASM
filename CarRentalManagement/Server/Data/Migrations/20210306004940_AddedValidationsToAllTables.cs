using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedValidationsToAllTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Vin",
                table: "Vehicles",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
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
                value: "2975db54-0587-46ff-b03f-1c6a04138609");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "79ee015d-f1ec-41cb-8e92-5e0ead246920");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0553fae9-0d26-4eb5-8d9b-2261a34a665b", "AQAAAAEAACcQAAAAEIyEnuVMTF7vCLG4+iQhjWkB1c4F4a+8XEO8z/oDSM5wcjW+TCEIWv4U9+hCe4dArA==", "7813e285-93a4-40a8-a032-84af25bf4c90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eba4ff40-7a76-4768-aa91-2946568248b1", "AQAAAAEAACcQAAAAELWqBq3nSs+oV5osvWkoyhchUQLj87EThZxKjoGJEQWWHzG4bC5tnqh6OXkO6wooIA==", "bb4b376d-a5eb-4793-b39e-d43a7c05da59" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 3, 5, 19, 49, 38, 136, DateTimeKind.Local).AddTicks(4509), new DateTime(2021, 3, 5, 19, 49, 38, 138, DateTimeKind.Local).AddTicks(8061) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 3, 5, 19, 49, 38, 138, DateTimeKind.Local).AddTicks(9821), new DateTime(2021, 3, 5, 19, 49, 38, 138, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 3, 5, 19, 49, 38, 142, DateTimeKind.Local).AddTicks(479), new DateTime(2021, 3, 5, 19, 49, 38, 142, DateTimeKind.Local).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 3, 5, 19, 49, 38, 142, DateTimeKind.Local).AddTicks(4439), new DateTime(2021, 3, 5, 19, 49, 38, 142, DateTimeKind.Local).AddTicks(4458) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 3, 5, 19, 49, 38, 143, DateTimeKind.Local).AddTicks(5644), new DateTime(2021, 3, 5, 19, 49, 38, 143, DateTimeKind.Local).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 3, 5, 19, 49, 38, 143, DateTimeKind.Local).AddTicks(6548), new DateTime(2021, 3, 5, 19, 49, 38, 143, DateTimeKind.Local).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 3, 5, 19, 49, 38, 143, DateTimeKind.Local).AddTicks(6559), new DateTime(2021, 3, 5, 19, 49, 38, 143, DateTimeKind.Local).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 3, 5, 19, 49, 38, 143, DateTimeKind.Local).AddTicks(6563), new DateTime(2021, 3, 5, 19, 49, 38, 143, DateTimeKind.Local).AddTicks(6565) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Vin",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
