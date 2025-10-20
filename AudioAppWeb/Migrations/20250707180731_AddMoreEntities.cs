using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AudioAppWeb.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Address_TheAddressId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Episode_AspNetUsers_CreatedById",
                table: "Episode");

            migrationBuilder.DropForeignKey(
                name: "FK_Episode_MainStory_MainStoryID",
                table: "Episode");

            migrationBuilder.DropForeignKey(
                name: "FK_MainStory_AspNetUsers_ApplicationUserId",
                table: "MainStory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MainStory",
                table: "MainStory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Episode",
                table: "Episode");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.RenameTable(
                name: "MainStory",
                newName: "MainStories");

            migrationBuilder.RenameTable(
                name: "Episode",
                newName: "Episodes");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_MainStory_ApplicationUserId",
                table: "MainStories",
                newName: "IX_MainStories_ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Episode_MainStoryID",
                table: "Episodes",
                newName: "IX_Episodes_MainStoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Episode_CreatedById",
                table: "Episodes",
                newName: "IX_Episodes_CreatedById");

            migrationBuilder.AddColumn<int>(
                name: "ChatboxId",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MainStories",
                table: "MainStories",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Episodes",
                table: "Episodes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Chatboxes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AuthorName = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsGroupChat = table.Column<bool>(type: "INTEGER", nullable: false),
                    GroupName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chatboxes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserConversations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SenderId = table.Column<string>(type: "TEXT", nullable: true),
                    User2NameId = table.Column<string>(type: "TEXT", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserConversations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserConversations_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserConversations_AspNetUsers_User2NameId",
                        column: x => x.User2NameId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AuthorId = table.Column<string>(type: "TEXT", nullable: true),
                    Content = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TotalLikes = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalDisLikes = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPosts_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AuthorNameId = table.Column<string>(type: "TEXT", nullable: true),
                    Content = table.Column<string>(type: "TEXT", nullable: true),
                    SentAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsRead = table.Column<bool>(type: "INTEGER", nullable: false),
                    ChatboxId = table.Column<int>(type: "INTEGER", nullable: true),
                    UserConversationId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserMessages_AspNetUsers_AuthorNameId",
                        column: x => x.AuthorNameId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserMessages_Chatboxes_ChatboxId",
                        column: x => x.ChatboxId,
                        principalTable: "Chatboxes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserMessages_UserConversations_UserConversationId",
                        column: x => x.UserConversationId,
                        principalTable: "UserConversations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserComment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AuthorId = table.Column<string>(type: "TEXT", nullable: true),
                    Content = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserPostId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserComment_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserComment_UserPosts_UserPostId",
                        column: x => x.UserPostId,
                        principalTable: "UserPosts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ChatboxId",
                table: "AspNetUsers",
                column: "ChatboxId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComment_AuthorId",
                table: "UserComment",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComment_UserPostId",
                table: "UserComment",
                column: "UserPostId");

            migrationBuilder.CreateIndex(
                name: "IX_UserConversations_SenderId",
                table: "UserConversations",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_UserConversations_User2NameId",
                table: "UserConversations",
                column: "User2NameId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMessages_AuthorNameId",
                table: "UserMessages",
                column: "AuthorNameId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMessages_ChatboxId",
                table: "UserMessages",
                column: "ChatboxId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMessages_UserConversationId",
                table: "UserMessages",
                column: "UserConversationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPosts_AuthorId",
                table: "UserPosts",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Addresses_TheAddressId",
                table: "AspNetUsers",
                column: "TheAddressId",
                principalTable: "Addresses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Chatboxes_ChatboxId",
                table: "AspNetUsers",
                column: "ChatboxId",
                principalTable: "Chatboxes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_AspNetUsers_CreatedById",
                table: "Episodes",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_MainStories_MainStoryID",
                table: "Episodes",
                column: "MainStoryID",
                principalTable: "MainStories",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_MainStories_AspNetUsers_ApplicationUserId",
                table: "MainStories",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Addresses_TheAddressId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Chatboxes_ChatboxId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_AspNetUsers_CreatedById",
                table: "Episodes");

            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_MainStories_MainStoryID",
                table: "Episodes");

            migrationBuilder.DropForeignKey(
                name: "FK_MainStories_AspNetUsers_ApplicationUserId",
                table: "MainStories");

            migrationBuilder.DropTable(
                name: "UserComment");

            migrationBuilder.DropTable(
                name: "UserMessages");

            migrationBuilder.DropTable(
                name: "UserPosts");

            migrationBuilder.DropTable(
                name: "Chatboxes");

            migrationBuilder.DropTable(
                name: "UserConversations");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ChatboxId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MainStories",
                table: "MainStories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Episodes",
                table: "Episodes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "ChatboxId",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "MainStories",
                newName: "MainStory");

            migrationBuilder.RenameTable(
                name: "Episodes",
                newName: "Episode");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_MainStories_ApplicationUserId",
                table: "MainStory",
                newName: "IX_MainStory_ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Episodes_MainStoryID",
                table: "Episode",
                newName: "IX_Episode_MainStoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Episodes_CreatedById",
                table: "Episode",
                newName: "IX_Episode_CreatedById");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MainStory",
                table: "MainStory",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Episode",
                table: "Episode",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Address_TheAddressId",
                table: "AspNetUsers",
                column: "TheAddressId",
                principalTable: "Address",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Episode_AspNetUsers_CreatedById",
                table: "Episode",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Episode_MainStory_MainStoryID",
                table: "Episode",
                column: "MainStoryID",
                principalTable: "MainStory",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_MainStory_AspNetUsers_ApplicationUserId",
                table: "MainStory",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
