using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoLocacao.Migrations
{
    public partial class versãoLocal10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cpf = table.Column<string>(nullable: true),
                    nome = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    criadoEm = table.Column<DateTime>(nullable: false),
                    nascimento = table.Column<DateTime>(nullable: false),
                    telefone = table.Column<string>(nullable: true),
                    cnh = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
