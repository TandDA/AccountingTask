using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountingTask.Migrations
{
    public partial class NewName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumptions_AspNetUsers_UserId",
                table: "Consumptions");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Consumptions",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Consumptions_UserId",
                table: "Consumptions",
                newName: "IX_Consumptions_ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consumptions_AspNetUsers_ApplicationUserId",
                table: "Consumptions",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumptions_AspNetUsers_ApplicationUserId",
                table: "Consumptions");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Consumptions",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Consumptions_ApplicationUserId",
                table: "Consumptions",
                newName: "IX_Consumptions_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consumptions_AspNetUsers_UserId",
                table: "Consumptions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
