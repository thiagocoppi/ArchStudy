using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankApplication.Infraestrutura.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Associado",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Endereco_Logradouro = table.Column<string>(nullable: true),
                    Endereco_Numero = table.Column<int>(nullable: false),
                    Endereco_Complemento = table.Column<string>(nullable: true),
                    Genero = table.Column<int>(nullable: false),
                    DadosPessoais_CPF = table.Column<string>(nullable: true),
                    DadosPessoais_Profissao = table.Column<string>(nullable: true),
                    DadosPessoais_Salario = table.Column<decimal>(nullable: false),
                    DadosPessoais_Idade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Associado", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Associado");
        }
    }
}
