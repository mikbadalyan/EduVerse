using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduVerse.Migrations
{
    /// <inheritdoc />
    public partial class Inineww : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Coin",
                table: "NewEntities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Lesson",
                table: "NewEntities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LessonType",
                table: "NewEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Topic",
                table: "NewEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Coin",
                table: "NewEntities");

            migrationBuilder.DropColumn(
                name: "Lesson",
                table: "NewEntities");

            migrationBuilder.DropColumn(
                name: "LessonType",
                table: "NewEntities");

            migrationBuilder.DropColumn(
                name: "Topic",
                table: "NewEntities");
        }
    }
}
