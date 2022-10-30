using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Autoserwis.Data.Migrations
{
    public partial class migracja4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerCarDateDay",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "CustomerCarDateTime",
                table: "Customers",
                newName: "CustomerCarDateDayTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CustomerCarDateDayTime",
                table: "Customers",
                newName: "CustomerCarDateTime");

            migrationBuilder.AddColumn<DateTime>(
                name: "CustomerCarDateDay",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
