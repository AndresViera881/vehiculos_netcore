using Microsoft.EntityFrameworkCore.Migrations;

namespace vehiculos.api.Migrations
{
    public partial class addTableTipoVehiculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoVehiculo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoVehiculo", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TipoVehiculo_Nombre",
                table: "TipoVehiculo",
                column: "Nombre",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TipoVehiculo");
        }
    }
}
