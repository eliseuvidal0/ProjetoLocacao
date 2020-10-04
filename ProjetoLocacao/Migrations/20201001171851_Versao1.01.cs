using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoLocacao.Migrations
{
    public partial class Versao101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Devolucoes");

            migrationBuilder.AddColumn<double>(
                name: "custoVariavel",
                table: "Locacoes",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "dataEntrega",
                table: "Locacoes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "devolvido",
                table: "Locacoes",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "custoVariavel",
                table: "Locacoes");

            migrationBuilder.DropColumn(
                name: "dataEntrega",
                table: "Locacoes");

            migrationBuilder.DropColumn(
                name: "devolvido",
                table: "Locacoes");

            migrationBuilder.CreateTable(
                name: "Devolucoes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clienteid = table.Column<int>(type: "int", nullable: true),
                    custoVariavel = table.Column<double>(type: "float", nullable: false),
                    dataEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    veiculoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devolucoes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Devolucoes_Clientes_clienteid",
                        column: x => x.clienteid,
                        principalTable: "Clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Devolucoes_veiculos_veiculoid",
                        column: x => x.veiculoid,
                        principalTable: "veiculos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Devolucoes_clienteid",
                table: "Devolucoes",
                column: "clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_Devolucoes_veiculoid",
                table: "Devolucoes",
                column: "veiculoid");
        }
    }
}
