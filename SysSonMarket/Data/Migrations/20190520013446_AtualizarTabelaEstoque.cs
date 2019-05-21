using Microsoft.EntityFrameworkCore.Migrations;

namespace SysSonMarket.Data.Migrations
{
    public partial class AtualizarTabelaEstoque : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Estoques",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Estoques");
        }
    }
}
