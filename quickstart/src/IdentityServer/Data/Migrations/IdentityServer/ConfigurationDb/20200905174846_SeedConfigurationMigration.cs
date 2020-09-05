using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Data.Migrations.IdentityServer.ConfigurationDb
{
    public partial class SeedConfigurationMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApiResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 48, 46, 226, DateTimeKind.Utc).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 48, 46, 230, DateTimeKind.Utc).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 48, 46, 232, DateTimeKind.Utc).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 48, 46, 232, DateTimeKind.Utc).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 48, 46, 229, DateTimeKind.Utc).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 48, 46, 229, DateTimeKind.Utc).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 48, 46, 229, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 48, 46, 229, DateTimeKind.Utc).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 48, 46, 228, DateTimeKind.Utc).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 48, 46, 228, DateTimeKind.Utc).AddTicks(8691));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApiResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 47, 57, 912, DateTimeKind.Utc).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 47, 57, 915, DateTimeKind.Utc).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 47, 57, 918, DateTimeKind.Utc).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 47, 57, 918, DateTimeKind.Utc).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 47, 57, 915, DateTimeKind.Utc).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 47, 57, 915, DateTimeKind.Utc).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 47, 57, 915, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 47, 57, 915, DateTimeKind.Utc).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 47, 57, 914, DateTimeKind.Utc).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 47, 57, 914, DateTimeKind.Utc).AddTicks(6624));
        }
    }
}
