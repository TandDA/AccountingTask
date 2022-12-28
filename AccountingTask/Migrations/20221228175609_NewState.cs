using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountingTask.Migrations
{
    public partial class NewState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Consumptions",
                newName: "UserId");

            migrationBuilder.AlterColumn<double>(
                name: "ConsumptionSum",
                table: "Consumptions",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Consumptions",
                newName: "ApplicationUserId");

            migrationBuilder.AlterColumn<int>(
                name: "ConsumptionSum",
                table: "Consumptions",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
