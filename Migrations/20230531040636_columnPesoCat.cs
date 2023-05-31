using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace vscode.Migrations
{
    /// <inheritdoc />
    public partial class columnPesoCat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "peso",
                table: "Categoria",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "peso",
                table: "Categoria");
        }
    }
}
