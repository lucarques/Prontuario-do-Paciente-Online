using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Prontuario_do_Paciente_Online.Migrations
{
    /// <inheritdoc />
    public partial class primeiramigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsuarioAcesso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Usuario = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    SenhaAcesso = table.Column<string>(type: "text", nullable: false),
                    TipoAcesso = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioAcesso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Acompanhante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeAcompanhante = table.Column<string>(type: "text", nullable: false),
                    CpfAcompanhante = table.Column<string>(type: "text", nullable: false),
                    EstadoAcompanhante = table.Column<string>(type: "text", nullable: false),
                    CidadeAcompanhante = table.Column<string>(type: "text", nullable: false),
                    EnderecoAcompanhante = table.Column<string>(type: "text", nullable: false),
                    NumeroAcompanhante = table.Column<int>(type: "integer", nullable: false),
                    GrauParentesco = table.Column<string>(type: "text", nullable: false),
                    UsuarioAcessoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acompanhante", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Acompanhante_UsuarioAcesso_UsuarioAcessoId",
                        column: x => x.UsuarioAcessoId,
                        principalTable: "UsuarioAcesso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Idade = table.Column<int>(type: "integer", nullable: false),
                    Cpf = table.Column<string>(type: "text", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: false),
                    Cidade = table.Column<string>(type: "text", nullable: false),
                    Endereco = table.Column<string>(type: "text", nullable: false),
                    Numero = table.Column<int>(type: "integer", nullable: false),
                    MotivoInternacao = table.Column<string>(type: "text", nullable: false),
                    AcompanhanteId = table.Column<int>(type: "integer", nullable: false),
                    StatusPaciente = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Paciente_Acompanhante_AcompanhanteId",
                        column: x => x.AcompanhanteId,
                        principalTable: "Acompanhante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Acompanhante_UsuarioAcessoId",
                table: "Acompanhante",
                column: "UsuarioAcessoId");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_AcompanhanteId",
                table: "Paciente",
                column: "AcompanhanteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "Acompanhante");

            migrationBuilder.DropTable(
                name: "UsuarioAcesso");
        }
    }
}
