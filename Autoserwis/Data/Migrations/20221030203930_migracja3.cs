using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Autoserwis.Data.Migrations
{
    public partial class migracja3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerPhoneNr = table.Column<int>(type: "int", nullable: false),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerCarRegistration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerCarMark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerCarModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerCarCapitality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerCarProductionYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerCarEngine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerCarVIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerCarMileage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerCarDateDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerCarDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerService = table.Column<int>(type: "int", nullable: false),
                    CustomerStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
