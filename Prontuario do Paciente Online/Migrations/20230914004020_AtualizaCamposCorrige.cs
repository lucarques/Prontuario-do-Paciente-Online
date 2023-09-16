using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prontuario_do_Paciente_Online.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaCamposCorrige : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_Prontuario_ProntuarioId",
                table: "Paciente");

            migrationBuilder.AlterColumn<int>(
                name: "ProntuarioId",
                table: "Paciente",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_Prontuario_ProntuarioId",
                table: "Paciente",
                column: "ProntuarioId",
                principalTable: "Prontuario",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_Prontuario_ProntuarioId",
                table: "Paciente");

            migrationBuilder.AlterColumn<int>(
                name: "ProntuarioId",
                table: "Paciente",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_Prontuario_ProntuarioId",
                table: "Paciente",
                column: "ProntuarioId",
                principalTable: "Prontuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
