using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Laundry.Migrations
{
    public partial class Init2 : Migration
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
                    clientNumber = table.Column<string>(type: "text", nullable: true),
                    time = table.Column<string>(type: "text", nullable: true),
                    date = table.Column<string>(type: "text", nullable: true),
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
                    clientNumber = table.Column<string>(type: "text", nullable: true),
                    time = table.Column<string>(type: "text", nullable: true),
                    date = table.Column<string>(type: "text", nullable: true),
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
