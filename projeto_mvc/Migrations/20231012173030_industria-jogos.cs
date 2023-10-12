using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projeto_mvc.Migrations
{
    /// <inheritdoc />
    public partial class industriajogos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Desenvolvedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogoImg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desenvolvedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plataformas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogoImg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataLancamento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plataformas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jogos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CapaImg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_Dev = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jogos_Desenvolvedores_Id_Dev",
                        column: x => x.Id_Dev,
                        principalTable: "Desenvolvedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JogoPlataforma",
                columns: table => new
                {
                    jogosId = table.Column<int>(type: "int", nullable: false),
                    plataformasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JogoPlataforma", x => new { x.jogosId, x.plataformasId });
                    table.ForeignKey(
                        name: "FK_JogoPlataforma_Jogos_jogosId",
                        column: x => x.jogosId,
                        principalTable: "Jogos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JogoPlataforma_Plataformas_plataformasId",
                        column: x => x.plataformasId,
                        principalTable: "Plataformas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlataformaJogos",
                columns: table => new
                {
                    IdPlataforma = table.Column<int>(type: "int", nullable: false),
                    IdJogo = table.Column<int>(type: "int", nullable: false),
                    plataformaId = table.Column<int>(type: "int", nullable: false),
                    jogoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlataformaJogos", x => new { x.IdJogo, x.IdPlataforma });
                    table.ForeignKey(
                        name: "FK_PlataformaJogos_Jogos_jogoId",
                        column: x => x.jogoId,
                        principalTable: "Jogos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlataformaJogos_Plataformas_plataformaId",
                        column: x => x.plataformaId,
                        principalTable: "Plataformas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JogoPlataforma_plataformasId",
                table: "JogoPlataforma",
                column: "plataformasId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogos_Id_Dev",
                table: "Jogos",
                column: "Id_Dev");

            migrationBuilder.CreateIndex(
                name: "IX_PlataformaJogos_jogoId",
                table: "PlataformaJogos",
                column: "jogoId");

            migrationBuilder.CreateIndex(
                name: "IX_PlataformaJogos_plataformaId",
                table: "PlataformaJogos",
                column: "plataformaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JogoPlataforma");

            migrationBuilder.DropTable(
                name: "PlataformaJogos");

            migrationBuilder.DropTable(
                name: "Jogos");

            migrationBuilder.DropTable(
                name: "Plataformas");

            migrationBuilder.DropTable(
                name: "Desenvolvedores");
        }
    }
}
