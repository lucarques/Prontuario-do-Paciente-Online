using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prontuario_do_Paciente_Online.Migrations
{
    /// <inheritdoc />
    public partial class TelaInicialDoAcompanhante : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmailAcompanhante",
                table: "Acompanhante",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailAcompanhante",
                table: "Acompanhante");
        }
    }
}
