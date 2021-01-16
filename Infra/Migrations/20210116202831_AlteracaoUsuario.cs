using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class AlteracaoUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Pessoa",
                table: "Usuario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pessoa",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Usuario");
        }
    }
}
