using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatWeb.Migrations
{
    /// <inheritdoc />
    public partial class Yasen1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "Cats",
                newName: "ImageUrl");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Cats",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Cats");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Cats",
                newName: "ImageURL");
        }
    }
}
