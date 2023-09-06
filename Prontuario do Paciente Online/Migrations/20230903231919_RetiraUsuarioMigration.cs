using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Prontuario_do_Paciente_Online.Migrations
{
    /// <inheritdoc />
    public partial class RetiraUsuarioMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Acompanhante_UsuarioAcesso_UsuarioAcessoId",
                table: "Acompanhante");

            migrationBuilder.DropTable(
                name: "UsuarioAcesso");

            migrationBuilder.DropIndex(
                name: "IX_Acompanhante_UsuarioAcessoId",
                table: "Acompanhante");

            migrationBuilder.DropColumn(
                name: "UsuarioAcessoId",
                table: "Acompanhante");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioAcessoId",
                table: "Acompanhante",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UsuarioAcesso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: false),
                    SenhaAcesso = table.Column<string>(type: "text", nullable: false),
                    TipoAcesso = table.Column<int>(type: "integer", nullable: false),
                    Usuario = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioAcesso", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Acompanhante_UsuarioAcessoId",
                table: "Acompanhante",
                column: "UsuarioAcessoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Acompanhante_UsuarioAcesso_UsuarioAcessoId",
                table: "Acompanhante",
                column: "UsuarioAcessoId",
                principalTable: "UsuarioAcesso",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
