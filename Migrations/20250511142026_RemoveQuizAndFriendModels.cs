using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sistation.Migrations
{
    /// <inheritdoc />
    public partial class RemoveQuizAndFriendModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Quizzes");
            migrationBuilder.DropTable(name: "Friends");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
