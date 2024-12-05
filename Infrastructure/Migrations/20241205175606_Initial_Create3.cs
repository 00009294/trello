using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial_Create3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Desks_DeskId",
                table: "Cards");

            migrationBuilder.AlterColumn<int>(
                name: "DeskId",
                table: "Cards",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Desks_DeskId",
                table: "Cards",
                column: "DeskId",
                principalTable: "Desks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Desks_DeskId",
                table: "Cards");

            migrationBuilder.AlterColumn<int>(
                name: "DeskId",
                table: "Cards",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Desks_DeskId",
                table: "Cards",
                column: "DeskId",
                principalTable: "Desks",
                principalColumn: "Id");
        }
    }
}
