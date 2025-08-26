using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AudioAppWeb.Migrations
{
    /// <inheritdoc />
    public partial class AddDateCreatedToMainStory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_MainStories_MainStoryID",
                table: "Episodes");

            migrationBuilder.RenameColumn(
                name: "MainStoryID",
                table: "Episodes",
                newName: "MainStoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Episodes_MainStoryID",
                table: "Episodes",
                newName: "IX_Episodes_MainStoryId");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "MainStories",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "MainStoryId",
                table: "Episodes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_MainStories_MainStoryId",
                table: "Episodes",
                column: "MainStoryId",
                principalTable: "MainStories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_MainStories_MainStoryId",
                table: "Episodes");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "MainStories");

            migrationBuilder.RenameColumn(
                name: "MainStoryId",
                table: "Episodes",
                newName: "MainStoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Episodes_MainStoryId",
                table: "Episodes",
                newName: "IX_Episodes_MainStoryID");

            migrationBuilder.AlterColumn<int>(
                name: "MainStoryID",
                table: "Episodes",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_MainStories_MainStoryID",
                table: "Episodes",
                column: "MainStoryID",
                principalTable: "MainStories",
                principalColumn: "ID");
        }
    }
}
