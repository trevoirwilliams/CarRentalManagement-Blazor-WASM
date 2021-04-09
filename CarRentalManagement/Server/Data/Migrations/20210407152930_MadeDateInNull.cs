using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class MadeDateInNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "d34ed0d9-a354-4173-ac7a-ca829a53a719");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "a14762fe-ed70-40b0-8e0b-47fa00f8b3db");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c28f91c-4119-4dcc-acc3-b6b54014f5d3", "AQAAAAEAACcQAAAAEA8L09FTy3t1W6OkDMfZz/mc4L8/THdW3T3KG6t9jG2+yEH+rQnyVsUOIKAxeynpTQ==", "9982d9ed-47d8-4fab-9933-cc7ec2170633" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98bf9c5d-709e-441b-950e-bf5fca08c6ff", "AQAAAAEAACcQAAAAEHEQw3hloCI4ZwlOGgLiPFyZnDs+UmamJVpwUzAoqmclgiHrNzqczFnHDJTPPsmvsQ==", "f61b3b83-2c63-4ff0-bb28-c89fe24819ca" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 7, 10, 29, 30, 243, DateTimeKind.Local).AddTicks(3643), new DateTime(2021, 4, 7, 10, 29, 30, 244, DateTimeKind.Local).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 7, 10, 29, 30, 244, DateTimeKind.Local).AddTicks(3299), new DateTime(2021, 4, 7, 10, 29, 30, 244, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 7, 10, 29, 30, 245, DateTimeKind.Local).AddTicks(5379), new DateTime(2021, 4, 7, 10, 29, 30, 245, DateTimeKind.Local).AddTicks(5387) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 7, 10, 29, 30, 245, DateTimeKind.Local).AddTicks(5857), new DateTime(2021, 4, 7, 10, 29, 30, 245, DateTimeKind.Local).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 7, 10, 29, 30, 245, DateTimeKind.Local).AddTicks(9308), new DateTime(2021, 4, 7, 10, 29, 30, 245, DateTimeKind.Local).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 7, 10, 29, 30, 245, DateTimeKind.Local).AddTicks(9778), new DateTime(2021, 4, 7, 10, 29, 30, 245, DateTimeKind.Local).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 7, 10, 29, 30, 245, DateTimeKind.Local).AddTicks(9784), new DateTime(2021, 4, 7, 10, 29, 30, 245, DateTimeKind.Local).AddTicks(9785) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 7, 10, 29, 30, 245, DateTimeKind.Local).AddTicks(9786), new DateTime(2021, 4, 7, 10, 29, 30, 245, DateTimeKind.Local).AddTicks(9787) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
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
    }
}
