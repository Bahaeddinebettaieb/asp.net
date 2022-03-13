using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations.Covid
{
    public partial class mgMedecin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "patient",
                table: "Consultation",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Doc",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    docName = table.Column<string>(nullable: false),
                    speciality = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doc", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Medecin",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    medecinName = table.Column<string>(nullable: true),
                    speciality = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medecin", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doc");

            migrationBuilder.DropTable(
                name: "Medecin");

            migrationBuilder.DropColumn(
                name: "patient",
                table: "Consultation");
        }
    }
}
