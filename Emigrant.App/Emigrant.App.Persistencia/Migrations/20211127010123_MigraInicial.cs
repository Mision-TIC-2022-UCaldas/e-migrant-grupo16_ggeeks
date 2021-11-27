using Microsoft.EntityFrameworkCore.Migrations;

namespace Emigrant.App.Persistencia.Migrations
{
    public partial class MigraInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Migrantes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipodocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numeroidentificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    paisorigen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechanacimiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccionactual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    situacionlaboral = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Migrantes", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Migrantes");
        }
    }
}
