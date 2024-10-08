using Microsoft.EntityFrameworkCore.Migrations;

namespace TPGrupo4.Migrations
{
    public partial class InicialOficial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Objetos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Objetos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
