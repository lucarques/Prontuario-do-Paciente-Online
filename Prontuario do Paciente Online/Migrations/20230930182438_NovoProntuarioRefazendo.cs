using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prontuario_do_Paciente_Online.Migrations
{
    /// <inheritdoc />
    public partial class NovoProntuarioRefazendo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Quarto",
                table: "Prontuario",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Quarto",
                table: "Prontuario",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
