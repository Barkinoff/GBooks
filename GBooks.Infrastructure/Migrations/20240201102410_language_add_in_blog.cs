using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GBooks.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class language_add_in_blog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "language_id",
                table: "blogs",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_blogs_language_id",
                table: "blogs",
                column: "language_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_blogs_languages_language_id",
                table: "blogs",
                column: "language_id",
                principalTable: "languages",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blogs_languages_language_id",
                table: "blogs");

            migrationBuilder.DropIndex(
                name: "IX_blogs_language_id",
                table: "blogs");

            migrationBuilder.DropColumn(
                name: "language_id",
                table: "blogs");
        }
    }
}
