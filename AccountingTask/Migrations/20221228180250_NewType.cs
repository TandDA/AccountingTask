using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountingTask.Migrations
{
    public partial class NewType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumptions_AspNetUsers_UserId1",
                table: "Consumptions");

            migrationBuilder.DropIndex(
                name: "IX_Consumptions_UserId1",
                table: "Consumptions");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Consumptions");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Consumptions",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Consumptions_UserId",
                table: "Consumptions",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consumptions_AspNetUsers_UserId",
                table: "Consumptions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumptions_AspNetUsers_UserId",
                table: "Consumptions");

            migrationBuilder.DropIndex(
                name: "IX_Consumptions_UserId",
                table: "Consumptions");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Consumptions",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Consumptions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Consumptions_UserId1",
                table: "Consumptions",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Consumptions_AspNetUsers_UserId1",
                table: "Consumptions",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
