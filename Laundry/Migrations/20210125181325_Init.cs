using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Laundry.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "firstMachineOrders",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    clientName = table.Column<string>(type: "text", nullable: true),
                    clientSurname = table.Column<string>(type: "text", nullable: true),
                    reservationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    machineNumber = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_firstMachineOrders", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "secondMachineOrders",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    clientName = table.Column<string>(type: "text", nullable: true),
                    clientSurname = table.Column<string>(type: "text", nullable: true),
                    reservationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    machineNumber = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_secondMachineOrders", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "firstMachineOrders");

            migrationBuilder.DropTable(
                name: "secondMachineOrders");
        }
    }
}
