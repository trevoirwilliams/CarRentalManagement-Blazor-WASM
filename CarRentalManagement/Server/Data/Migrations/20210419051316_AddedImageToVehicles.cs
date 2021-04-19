using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedImageToVehicles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "160d52d0-91a2-40fc-bb9f-306d8a75631f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "a21a1716-86dd-4ea4-8198-60825a572572");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0928adbf-d632-4657-9f63-cd35018e4b2b", "AQAAAAEAACcQAAAAED4LB8NNgbc3d2LQHOFaSvlBchRW5QGJH9vOWc3ypVYvMOVmlVEpP5CcSYSH47Enfw==", "5386b44e-69ac-4d0b-a8ee-230565eb1a74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b318c681-af0c-43c9-92c7-06d1cb92e9fd", "AQAAAAEAACcQAAAAEJatKXqIKKFCPivIxi+AR5J4iyk8SBAAPFFUAbX3xfKJVaIhBM79EOob85Rhg0lK4w==", "483d5904-f3f2-4375-beb0-0c639aa6d495" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 19, 0, 13, 15, 557, DateTimeKind.Local).AddTicks(6998), new DateTime(2021, 4, 19, 0, 13, 15, 558, DateTimeKind.Local).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 19, 0, 13, 15, 558, DateTimeKind.Local).AddTicks(6329), new DateTime(2021, 4, 19, 0, 13, 15, 558, DateTimeKind.Local).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 19, 0, 13, 15, 559, DateTimeKind.Local).AddTicks(8917), new DateTime(2021, 4, 19, 0, 13, 15, 559, DateTimeKind.Local).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 19, 0, 13, 15, 559, DateTimeKind.Local).AddTicks(9471), new DateTime(2021, 4, 19, 0, 13, 15, 559, DateTimeKind.Local).AddTicks(9475) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 19, 0, 13, 15, 560, DateTimeKind.Local).AddTicks(3095), new DateTime(2021, 4, 19, 0, 13, 15, 560, DateTimeKind.Local).AddTicks(3101) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 19, 0, 13, 15, 560, DateTimeKind.Local).AddTicks(3580), new DateTime(2021, 4, 19, 0, 13, 15, 560, DateTimeKind.Local).AddTicks(3583) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 19, 0, 13, 15, 560, DateTimeKind.Local).AddTicks(3585), new DateTime(2021, 4, 19, 0, 13, 15, 560, DateTimeKind.Local).AddTicks(3586) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 19, 0, 13, 15, 560, DateTimeKind.Local).AddTicks(3588), new DateTime(2021, 4, 19, 0, 13, 15, 560, DateTimeKind.Local).AddTicks(3589) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Vehicles");

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
    }
}
