using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduVerse.Migrations
{
    /// <inheritdoc />
    public partial class StudentUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "StudUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "StudUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "CvPdfLink",
                table: "StudUsers",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "StudUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FacebookLink",
                table: "StudUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "StudUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GithubLink",
                table: "StudUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InstagramLink",
                table: "StudUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkedinLink",
                table: "StudUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "StudUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "StudUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SoftSkills",
                table: "StudUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "StudUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TelegramLink",
                table: "StudUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "University",
                table: "StudUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "StudUsers");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "StudUsers");

            migrationBuilder.DropColumn(
                name: "CvPdfLink",
                table: "StudUsers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "StudUsers");

            migrationBuilder.DropColumn(
                name: "FacebookLink",
                table: "StudUsers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "StudUsers");

            migrationBuilder.DropColumn(
                name: "GithubLink",
                table: "StudUsers");

            migrationBuilder.DropColumn(
                name: "InstagramLink",
                table: "StudUsers");

            migrationBuilder.DropColumn(
                name: "LinkedinLink",
                table: "StudUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "StudUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "StudUsers");

            migrationBuilder.DropColumn(
                name: "SoftSkills",
                table: "StudUsers");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "StudUsers");

            migrationBuilder.DropColumn(
                name: "TelegramLink",
                table: "StudUsers");

            migrationBuilder.DropColumn(
                name: "University",
                table: "StudUsers");
        }
    }
}
