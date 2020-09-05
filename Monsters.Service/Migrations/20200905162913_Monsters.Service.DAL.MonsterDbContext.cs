using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Monsters.Service.Migrations
{
    public partial class MonstersServiceDALMonsterDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doors",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    KidBehindDoorName = table.Column<string>(maxLength: 20, nullable: true),
                    Power = table.Column<int>(nullable: false),
                    LastScare = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Scares",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    ScareBegin = table.Column<DateTime>(nullable: false),
                    ScareEnded = table.Column<DateTime>(nullable: false),
                    MonsterId = table.Column<string>(maxLength: 50, nullable: true),
                    DoorId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Scares_Doors_DoorId",
                        column: x => x.DoorId,
                        principalTable: "Doors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "Id", "KidBehindDoorName", "LastScare", "Power" },
                values: new object[,]
                {
                    { "door1", "Rosie", new DateTime(2020, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { "door2", "Abraham", new DateTime(2020, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 },
                    { "door3", "Moshe", new DateTime(2020, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { "door4", "Danny", new DateTime(2020, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 70 },
                    { "door5", "Yoni", new DateTime(2020, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 80 },
                    { "door6", "Lev", new DateTime(2020, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { "door7", "Maxim", new DateTime(2020, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Scares_DoorId",
                table: "Scares",
                column: "DoorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Scares");

            migrationBuilder.DropTable(
                name: "Doors");
        }
    }
}
