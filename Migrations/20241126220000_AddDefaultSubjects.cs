using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduVerse.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultSubjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DefaultSubjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Topic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lesson = table.Column<int>(type: "int", nullable: false),
                    Coin = table.Column<int>(type: "int", nullable: false),
                    LessonType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PathName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefaultSubjects", x => x.Id);
                });

            // Insert default subjects
            migrationBuilder.InsertData(
                table: "DefaultSubjects",
                columns: new[] { "Name", "Topic", "Lesson", "Coin", "LessonType", "PathName", "Status", "Color" },
                values: new object[,]
                {
                    { "Subject1", "Topic1", 1, 10, "CM", "Path1", "Not Done", "red" },
                    { "Subject2", "Topic2", 2, 20, "TD", "Path2", "Not Done", "red" },
                    { "Subject3", "Topic3", 3, 30, "CM", "Path3", "Not Done", "red" },
                    { "Subject4", "Topic4", 4, 40, "TD", "Path4", "Not Done", "red" },
                    { "Subject5", "Topic5", 5, 50, "CM", "Path5", "Not Done", "red" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DefaultSubjects");
        }
    }
}
