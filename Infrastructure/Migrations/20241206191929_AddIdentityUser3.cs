using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentityUser3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_AspNetUsers_AuthorId",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_AuthorId",
                table: "Cards");

            migrationBuilder.AlterColumn<int>(
                name: "PriorityId",
                table: "Cards",
                type: "integer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Cards",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "AuthorId1",
                table: "Cards",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cards_AuthorId1",
                table: "Cards",
                column: "AuthorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_AspNetUsers_AuthorId1",
                table: "Cards",
                column: "AuthorId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_AspNetUsers_AuthorId1",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_AuthorId1",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "AuthorId1",
                table: "Cards");

            migrationBuilder.AlterColumn<string>(
                name: "PriorityId",
                table: "Cards",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AuthorId",
                table: "Cards",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_AuthorId",
                table: "Cards",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_AspNetUsers_AuthorId",
                table: "Cards",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
