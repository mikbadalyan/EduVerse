using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduVerse.Migrations
{
    /// <inheritdoc />
    public partial class AddCoinColumnToUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Coin",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Coin",
                table: "Users");
        }
    }
}
