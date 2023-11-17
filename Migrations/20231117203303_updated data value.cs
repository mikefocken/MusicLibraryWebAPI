using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicLibraryWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateddatavalue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Likes",
                table: "Songs",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Likes",
                table: "Songs",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
