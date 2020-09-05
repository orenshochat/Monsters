using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Data.Migrations.IdentityServer.ConfigurationDb
{
    public partial class InitialConfigurationMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApiResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 49, 4, 311, DateTimeKind.Utc).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 49, 4, 315, DateTimeKind.Utc).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 49, 4, 318, DateTimeKind.Utc).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 49, 4, 318, DateTimeKind.Utc).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 49, 4, 314, DateTimeKind.Utc).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 49, 4, 314, DateTimeKind.Utc).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 49, 4, 314, DateTimeKind.Utc).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 49, 4, 314, DateTimeKind.Utc).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 49, 4, 313, DateTimeKind.Utc).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 9, 5, 17, 49, 4, 313, DateTimeKind.Utc).AddTicks(9054));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
