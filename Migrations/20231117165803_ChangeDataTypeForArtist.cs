using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicLibraryWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDataTypeForArtist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Artist",
                table: "Songs",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Artist",
                table: "Songs",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");
        }
    }
}
