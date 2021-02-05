using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace Laundry.Migrations
{
    public partial class initMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "firstMachineOrders",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    clientName = table.Column<string>(nullable: true),
                    clientSurname = table.Column<string>(nullable: true),
                    clientNumber = table.Column<string>(nullable: true),
                    time = table.Column<string>(nullable: true),
                    date = table.Column<string>(nullable: true),
                    machineNumber = table.Column<int>(nullable: false),
                    ipAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_firstMachineOrders", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "secondMachineOrders",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    clientName = table.Column<string>(nullable: true),
                    clientSurname = table.Column<string>(nullable: true),
                    clientNumber = table.Column<string>(nullable: true),
                    time = table.Column<string>(nullable: true),
                    date = table.Column<string>(nullable: true),
                    machineNumber = table.Column<int>(nullable: false),
                    ipAddress = table.Column<string>(nullable: true)
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
