using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicLibraryWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class addedlikebutton : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Likes",
                table: "Songs",
                type: "longtext",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Likes",
                table: "Songs");
        }
    }
}
