using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GBooks.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class blog_and_feedback_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_order_details_book_id",
                table: "order_details");

            migrationBuilder.DropIndex(
                name: "IX_order_details_cart_item_id",
                table: "order_details");

            migrationBuilder.AddColumn<long>(
                name: "order_id",
                table: "order_details",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "blogs",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    attachment_id = table.Column<long>(type: "bigint", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogs", x => x.id);
                    table.ForeignKey(
                        name: "FK_blogs_attachments_attachment_id",
                        column: x => x.attachment_id,
                        principalTable: "attachments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "feedbacks",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    text = table.Column<string>(type: "text", nullable: false),
                    book_id = table.Column<long>(type: "bigint", nullable: false),
                    user_id = table.Column<long>(type: "bigint", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_feedbacks", x => x.id);
                    table.ForeignKey(
                        name: "FK_feedbacks_books_book_id",
                        column: x => x.book_id,
                        principalTable: "books",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_feedbacks_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_order_details_book_id",
                table: "order_details",
                column: "book_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_order_details_cart_item_id",
                table: "order_details",
                column: "cart_item_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_order_details_order_id",
                table: "order_details",
                column: "order_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_blogs_attachment_id",
                table: "blogs",
                column: "attachment_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_feedbacks_book_id",
                table: "feedbacks",
                column: "book_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_feedbacks_user_id",
                table: "feedbacks",
                column: "user_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_order_details_orders_order_id",
                table: "order_details",
                column: "order_id",
                principalTable: "orders",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_details_orders_order_id",
                table: "order_details");

            migrationBuilder.DropTable(
                name: "blogs");

            migrationBuilder.DropTable(
                name: "feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_order_details_book_id",
                table: "order_details");

            migrationBuilder.DropIndex(
                name: "IX_order_details_cart_item_id",
                table: "order_details");

            migrationBuilder.DropIndex(
                name: "IX_order_details_order_id",
                table: "order_details");

            migrationBuilder.DropColumn(
                name: "order_id",
                table: "order_details");

            migrationBuilder.CreateIndex(
                name: "IX_order_details_book_id",
                table: "order_details",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_order_details_cart_item_id",
                table: "order_details",
                column: "cart_item_id");
        }
    }
}
