using Microsoft.EntityFrameworkCore.Migrations;

namespace GroomingSalonApp.Migrations
{
    public partial class enumState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "State",
                table: "CustomerAccounts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "CustomerAccounts",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
