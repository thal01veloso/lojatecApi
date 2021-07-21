using Microsoft.EntityFrameworkCore.Migrations;

namespace livrariaApi.Migrations
{
    public partial class produtoPC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProduto = table.Column<string>(nullable: true),
                    MarcaProduto = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    PlacaMae = table.Column<string>(nullable: true),
                    MemoriaRam = table.Column<int>(nullable: false),
                    HD = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
