using Microsoft.EntityFrameworkCore.Migrations;
using System.Collections.Generic;

namespace webapi.Migrations
{
    public partial class Firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarBrand",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarBrand", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "CarType",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    BodyType = table.Column<string>(type: "TEXT", nullable: true),
                    CarBrandName = table.Column<string>(type: "TEXT", nullable: true),
                    VehicleType = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarType", x => x.Name);
                    table.ForeignKey(
                        name: "FK_CarType_CarBrand_CarBrandName",
                        column: x => x.CarBrandName,
                        principalTable: "CarBrand",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarType_CarBrandName",
                table: "CarType",
                column: "CarBrandName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarType");

            migrationBuilder.DropTable(
                name: "CarBrand");
        }
    }
}
