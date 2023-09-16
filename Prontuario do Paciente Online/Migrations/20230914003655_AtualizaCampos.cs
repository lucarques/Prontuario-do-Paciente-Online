using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Prontuario_do_Paciente_Online.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaCampos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProntuarioId",
                table: "Paciente",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Crm = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prontuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Diagnostico = table.Column<string>(type: "text", nullable: false),
                    Quarto = table.Column<int>(type: "integer", nullable: false),
                    Observacao = table.Column<string>(type: "text", nullable: false),
                    DataProntuario = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MedicoId = table.Column<int>(type: "integer", nullable: false),
                    EnumStatus = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prontuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prontuario_Medico_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Medico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_ProntuarioId",
                table: "Paciente",
                column: "ProntuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Prontuario_MedicoId",
                table: "Prontuario",
                column: "MedicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_Prontuario_ProntuarioId",
                table: "Paciente",
                column: "ProntuarioId",
                principalTable: "Prontuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_Prontuario_ProntuarioId",
                table: "Paciente");

            migrationBuilder.DropTable(
                name: "Prontuario");

            migrationBuilder.DropTable(
                name: "Medico");

            migrationBuilder.DropIndex(
                name: "IX_Paciente_ProntuarioId",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "ProntuarioId",
                table: "Paciente");
        }
    }
}
