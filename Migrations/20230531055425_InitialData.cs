using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace vscode.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaID", "Descripcion", "Nombre", "peso" },
                values: new object[,]
                {
                    { new Guid("e8a90193-9f42-4348-a122-2aad81cb7741"), null, "Actividades Pendientes", 20 },
                    { new Guid("e8a90193-9f42-4348-a122-2aad81cb7742"), null, "Actividades Personales", 50 }
                });

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "TareaID", "CategoriaID", "Descripcion", "FechaCreacion", "Nombre", "PrioridadTarea" },
                values: new object[,]
                {
                    { new Guid("e8a90193-9f42-4348-a122-2aad81cb7743"), new Guid("e8a90193-9f42-4348-a122-2aad81cb7741"), null, new DateTime(2023, 5, 30, 22, 54, 25, 662, DateTimeKind.Local).AddTicks(627), "Pago de servicios publicos", 1 },
                    { new Guid("e8a90193-9f42-4348-a122-2aad81cb7744"), new Guid("e8a90193-9f42-4348-a122-2aad81cb7742"), null, new DateTime(2023, 5, 30, 22, 54, 25, 662, DateTimeKind.Local).AddTicks(692), "Terminar de ver pelicula", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaID",
                keyValue: new Guid("e8a90193-9f42-4348-a122-2aad81cb7743"));

            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaID",
                keyValue: new Guid("e8a90193-9f42-4348-a122-2aad81cb7744"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaID",
                keyValue: new Guid("e8a90193-9f42-4348-a122-2aad81cb7741"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaID",
                keyValue: new Guid("e8a90193-9f42-4348-a122-2aad81cb7742"));

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
