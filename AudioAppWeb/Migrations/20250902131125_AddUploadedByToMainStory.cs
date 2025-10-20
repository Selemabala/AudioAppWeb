using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AudioAppWeb.Migrations
{
    /// <inheritdoc />
    public partial class AddUploadedByToMainStory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MainStories_AspNetUsers_ApplicationUserId",
                table: "MainStories");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "MainStories",
                newName: "UploadedById");

            migrationBuilder.RenameIndex(
                name: "IX_MainStories_ApplicationUserId",
                table: "MainStories",
                newName: "IX_MainStories_UploadedById");

            migrationBuilder.AddForeignKey(
                name: "FK_MainStories_AspNetUsers_UploadedById",
                table: "MainStories",
                column: "UploadedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MainStories_AspNetUsers_UploadedById",
                table: "MainStories");

            migrationBuilder.RenameColumn(
                name: "UploadedById",
                table: "MainStories",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_MainStories_UploadedById",
                table: "MainStories",
                newName: "IX_MainStories_ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_MainStories_AspNetUsers_ApplicationUserId",
                table: "MainStories",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
