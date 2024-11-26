using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduVerse.Migrations
{
    /// <inheritdoc />
    public partial class Migrat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "NewEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PathName",
                table: "NewEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "NewEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "NewEntities");

            migrationBuilder.DropColumn(
                name: "PathName",
                table: "NewEntities");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "NewEntities");
        }
    }
}
