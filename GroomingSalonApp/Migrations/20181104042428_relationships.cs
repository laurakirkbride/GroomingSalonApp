using Microsoft.EntityFrameworkCore.Migrations;

namespace GroomingSalonApp.Migrations
{
    public partial class relationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Pets_CustomerId",
                table: "Pets",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_CustomerAccounts_CustomerId",
                table: "Pets",
                column: "CustomerId",
                principalTable: "CustomerAccounts",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_CustomerAccounts_CustomerId",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Pets_CustomerId",
                table: "Pets");
        }
    }
}
