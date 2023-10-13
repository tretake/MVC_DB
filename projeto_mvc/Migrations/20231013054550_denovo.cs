using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projeto_mvc.Migrations
{
    /// <inheritdoc />
    public partial class denovo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlataformaJogos_Jogos_jogoId",
                table: "PlataformaJogos");

            migrationBuilder.DropForeignKey(
                name: "FK_PlataformaJogos_Plataformas_plataformaId",
                table: "PlataformaJogos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlataformaJogos",
                table: "PlataformaJogos");

            migrationBuilder.DropIndex(
                name: "IX_PlataformaJogos_jogoId",
                table: "PlataformaJogos");

            migrationBuilder.DropColumn(
                name: "IdJogo",
                table: "PlataformaJogos");

            migrationBuilder.DropColumn(
                name: "IdPlataforma",
                table: "PlataformaJogos");

            migrationBuilder.RenameColumn(
                name: "plataformaId",
                table: "PlataformaJogos",
                newName: "PlataformaId");

            migrationBuilder.RenameColumn(
                name: "jogoId",
                table: "PlataformaJogos",
                newName: "JogoId");

            migrationBuilder.RenameIndex(
                name: "IX_PlataformaJogos_plataformaId",
                table: "PlataformaJogos",
                newName: "IX_PlataformaJogos_PlataformaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlataformaJogos",
                table: "PlataformaJogos",
                columns: new[] { "JogoId", "PlataformaId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PlataformaJogos_Jogos_JogoId",
                table: "PlataformaJogos",
                column: "JogoId",
                principalTable: "Jogos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlataformaJogos_Plataformas_PlataformaId",
                table: "PlataformaJogos",
                column: "PlataformaId",
                principalTable: "Plataformas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlataformaJogos_Jogos_JogoId",
                table: "PlataformaJogos");

            migrationBuilder.DropForeignKey(
                name: "FK_PlataformaJogos_Plataformas_PlataformaId",
                table: "PlataformaJogos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlataformaJogos",
                table: "PlataformaJogos");

            migrationBuilder.RenameColumn(
                name: "PlataformaId",
                table: "PlataformaJogos",
                newName: "plataformaId");

            migrationBuilder.RenameColumn(
                name: "JogoId",
                table: "PlataformaJogos",
                newName: "jogoId");

            migrationBuilder.RenameIndex(
                name: "IX_PlataformaJogos_PlataformaId",
                table: "PlataformaJogos",
                newName: "IX_PlataformaJogos_plataformaId");

            migrationBuilder.AddColumn<int>(
                name: "IdJogo",
                table: "PlataformaJogos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdPlataforma",
                table: "PlataformaJogos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlataformaJogos",
                table: "PlataformaJogos",
                columns: new[] { "IdJogo", "IdPlataforma" });

            migrationBuilder.CreateIndex(
                name: "IX_PlataformaJogos_jogoId",
                table: "PlataformaJogos",
                column: "jogoId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlataformaJogos_Jogos_jogoId",
                table: "PlataformaJogos",
                column: "jogoId",
                principalTable: "Jogos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlataformaJogos_Plataformas_plataformaId",
                table: "PlataformaJogos",
                column: "plataformaId",
                principalTable: "Plataformas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
