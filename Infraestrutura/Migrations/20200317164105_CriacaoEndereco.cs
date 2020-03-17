using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraestrutura.Migrations
{
    public partial class CriacaoEndereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Associados",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Associados",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Idade",
                table: "Associados",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Complemento",
                table: "Associados",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Logradouro",
                table: "Associados",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Numero",
                table: "Associados",
                nullable: true,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Associados");

            migrationBuilder.DropColumn(
                name: "Idade",
                table: "Associados");

            migrationBuilder.DropColumn(
                name: "Complemento",
                table: "Associados");

            migrationBuilder.DropColumn(
                name: "Logradouro",
                table: "Associados");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Associados");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Associados",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
