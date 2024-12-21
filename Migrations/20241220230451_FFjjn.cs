using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduVerse.Migrations
{
    /// <inheritdoc />
    public partial class FFjjn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Add a temporary column to store the converted data
            migrationBuilder.AddColumn<byte[]>(
                name: "PdfLinkTemp",
                table: "NewEntities",
                type: "varbinary(max)",
                nullable: true);

            // Convert the existing data from nvarchar(max) to varbinary(max)
            migrationBuilder.Sql(
                "UPDATE NewEntities SET PdfLinkTemp = CONVERT(varbinary(max), PdfLink)");

            // Drop the old column
            migrationBuilder.DropColumn(
                name: "PdfLink",
                table: "NewEntities");

            // Rename the temporary column to the original column name
            migrationBuilder.RenameColumn(
                name: "PdfLinkTemp",
                table: "NewEntities",
                newName: "PdfLink");

            // Alter the column to make it non-nullable
            migrationBuilder.AlterColumn<byte[]>(
                name: "PdfLink",
                table: "NewEntities",
                type: "varbinary(max)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Add a temporary column to store the converted data
            migrationBuilder.AddColumn<string>(
                name: "PdfLinkTemp",
                table: "NewEntities",
                type: "nvarchar(max)",
                nullable: true);

            // Convert the existing data from varbinary(max) to nvarchar(max)
            migrationBuilder.Sql(
                "UPDATE NewEntities SET PdfLinkTemp = CONVERT(nvarchar(max), PdfLink)");

            // Drop the old column
            migrationBuilder.DropColumn(
                name: "PdfLink",
                table: "NewEntities");

            // Rename the temporary column to the original column name
            migrationBuilder.RenameColumn(
                name: "PdfLinkTemp",
                table: "NewEntities",
                newName: "PdfLink");

            // Alter the column to make it non-nullable
            migrationBuilder.AlterColumn<string>(
                name: "PdfLink",
                table: "NewEntities",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
