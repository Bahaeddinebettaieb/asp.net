using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations.Covid
{
    public partial class updateMedecin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Medecin",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "Medecin",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "Medecin");

            migrationBuilder.DropColumn(
                name: "phone",
                table: "Medecin");
        }
    }
}
