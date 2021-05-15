using Microsoft.EntityFrameworkCore.Migrations;

namespace livrariaApi.Migrations
{
    public partial class AddColumnCor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cor",
                table: "Produtos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cor",
                table: "Produtos");
        }
    }
}
