using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Genealogi.Migrations
{
    public partial class withmany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_People_FatherId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_MotherId",
                table: "People");

            migrationBuilder.CreateIndex(
                name: "IX_People_FatherId",
                table: "People",
                column: "FatherId");

            migrationBuilder.CreateIndex(
                name: "IX_People_MotherId",
                table: "People",
                column: "MotherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_People_FatherId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_MotherId",
                table: "People");

            migrationBuilder.CreateIndex(
                name: "IX_People_FatherId",
                table: "People",
                column: "FatherId",
                unique: true,
                filter: "[FatherId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_People_MotherId",
                table: "People",
                column: "MotherId",
                unique: true,
                filter: "[MotherId] IS NOT NULL");
        }
    }
}
