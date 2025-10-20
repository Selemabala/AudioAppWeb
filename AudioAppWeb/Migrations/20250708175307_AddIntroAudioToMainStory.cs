using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AudioAppWeb.Migrations
{
    /// <inheritdoc />
    public partial class AddIntroAudioToMainStory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AudioIntroPath",
                table: "MainStories",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AudioIntroPath",
                table: "MainStories");
        }
    }
}
