using Microsoft.EntityFrameworkCore.Migrations;

namespace TPGrupo4.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Domicilio",
                columns: table => new
                {
                    Calle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Altura = table.Column<int>(type: "int", nullable: false),
                    CodigoPostal = table.Column<int>(type: "int", nullable: false),
                    EsCasa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domicilio", x => x.Calle);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    dni = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    usuario = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    contrasenia = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    nombreCompleto = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    domicilioCalle = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.dni);
                    table.ForeignKey(
                        name: "FK_Clientes_Domicilio_domicilioCalle",
                        column: x => x.domicilioCalle,
                        principalTable: "Domicilio",
                        principalColumn: "Calle",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_domicilioCalle",
                table: "Clientes",
                column: "domicilioCalle");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Domicilio");
        }
    }
}
