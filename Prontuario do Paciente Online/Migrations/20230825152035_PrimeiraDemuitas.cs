using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prontuario_do_Paciente_Online.Migrations
{
    /// <inheritdoc />
    public partial class PrimeiraDemuitas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Acompanhante");

            migrationBuilder.DropColumn(
                name: "SenhaAcessoAcompanhante",
                table: "Acompanhante");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Acompanhante",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SenhaAcessoAcompanhante",
                table: "Acompanhante",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
