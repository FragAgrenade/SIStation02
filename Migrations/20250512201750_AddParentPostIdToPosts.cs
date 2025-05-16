using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sistation.Migrations
{
    /// <inheritdoc />
    public partial class AddParentPostIdToPosts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentPostId",
                table: "Posts",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ParentPostId",
                table: "Posts",
                column: "ParentPostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Posts_ParentPostId",
                table: "Posts",
                column: "ParentPostId",
                principalTable: "Posts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Posts_ParentPostId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_ParentPostId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ParentPostId",
                table: "Posts");
        }
    }
}
