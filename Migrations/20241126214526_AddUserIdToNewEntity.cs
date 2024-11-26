using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduVerse.Migrations
{
    /// <inheritdoc />
    public partial class AddUserIdToNewEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "NewEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "NewEntities");
        }
    }
}
