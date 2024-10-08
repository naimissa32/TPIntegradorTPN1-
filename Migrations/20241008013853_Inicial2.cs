using Microsoft.EntityFrameworkCore.Migrations;

namespace TPGrupo4.Migrations
{
    public partial class Inicial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Domicilio_domicilioCalle",
                table: "Clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Domicilio",
                table: "Domicilio");

            migrationBuilder.DropColumn(
                name: "Altura",
                table: "Domicilio");

            migrationBuilder.RenameTable(
                name: "Domicilio",
                newName: "Domicilios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Domicilios",
                table: "Domicilios",
                column: "Calle");

            migrationBuilder.CreateTable(
                name: "Objetos",
                columns: table => new
                {
                    idObjeto = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Precio = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objetos", x => x.idObjeto);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    idVenta = table.Column<int>(type: "int", nullable: false),
                    cantObjeto = table.Column<int>(type: "int", nullable: false),
                    fechaCompra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    compradordni = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    vendedordni = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    itemidObjeto = table.Column<int>(type: "int", nullable: true),
                    medioPago = table.Column<int>(type: "int", nullable: false),
                    precioTotal = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.idVenta);
                    table.ForeignKey(
                        name: "FK_Ventas_Clientes_compradordni",
                        column: x => x.compradordni,
                        principalTable: "Clientes",
                        principalColumn: "dni",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ventas_Clientes_vendedordni",
                        column: x => x.vendedordni,
                        principalTable: "Clientes",
                        principalColumn: "dni",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ventas_Objetos_itemidObjeto",
                        column: x => x.itemidObjeto,
                        principalTable: "Objetos",
                        principalColumn: "idObjeto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_compradordni",
                table: "Ventas",
                column: "compradordni");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_itemidObjeto",
                table: "Ventas",
                column: "itemidObjeto");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_vendedordni",
                table: "Ventas",
                column: "vendedordni");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Domicilios_domicilioCalle",
                table: "Clientes",
                column: "domicilioCalle",
                principalTable: "Domicilios",
                principalColumn: "Calle",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Domicilios_domicilioCalle",
                table: "Clientes");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Objetos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Domicilios",
                table: "Domicilios");

            migrationBuilder.RenameTable(
                name: "Domicilios",
                newName: "Domicilio");

            migrationBuilder.AddColumn<int>(
                name: "Altura",
                table: "Domicilio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Domicilio",
                table: "Domicilio",
                column: "Calle");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Domicilio_domicilioCalle",
                table: "Clientes",
                column: "domicilioCalle",
                principalTable: "Domicilio",
                principalColumn: "Calle",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
