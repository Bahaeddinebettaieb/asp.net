using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations.Covid
{
    public partial class mg3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "location",
                table: "User",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "location",
                table: "User",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
