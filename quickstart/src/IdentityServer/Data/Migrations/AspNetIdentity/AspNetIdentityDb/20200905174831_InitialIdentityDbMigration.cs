using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Data.Migrations.AspNetIdentity.AspNetIdentityDb
{
    public partial class InitialIdentityDbMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f142e70-f82c-4429-9169-da74b3d7e312", "AQAAAAEAACcQAAAAEBHHu33I5EBYX8rfEbUsvcCtfOrsPgCpBgxarj4lk+tRCIV/zB5emZpf26+Xj/vDPA==", "c2dab3b7-60d0-40e8-8a89-f02791186101" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a1230c1-3051-44a5-9915-26f5e77611e6", "AQAAAAEAACcQAAAAEAE6NDRD/LoiG1u9TmPRXoL59E+Uzmgxxx3GHiQ9yOKt0WkvO8WbkCEx3wXjrlLnGg==", "2e9ec294-edc8-469b-afcc-8e0cac71a992" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "897c544a-1e03-4759-9aee-e22e07e2eeff", "AQAAAAEAACcQAAAAEJKTF9kywDuPKPzRaxs9/0Hz1KWtJkaoS57Zr4uwIwTgWmqtk6h//rXpKBB6oxRKuw==", "bccb1f47-b0e4-4c30-a5f4-26c36e7b9fb1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bcbddf0-543f-4ae3-a5a9-0135a9763d53", "AQAAAAEAACcQAAAAEJibvndnzIIzmQWfFO3hSvXLzL30VSpWhqf9sbeuXKQU353AU7azOuDfguBSTgB1jA==", "afa9990e-52fc-46c9-82ad-536e0a54b696" });
        }
    }
}
