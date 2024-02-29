using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArchitectureHouse.Migrations
{
    /// <inheritdoc />
    public partial class RelationshipCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mode",
                table: "Houses");

            migrationBuilder.AddColumn<int>(
                name: "ModeId",
                table: "Houses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Houses_ModeId",
                table: "Houses",
                column: "ModeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_Modes_ModeId",
                table: "Houses",
                column: "ModeId",
                principalTable: "Modes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Houses_Modes_ModeId",
                table: "Houses");

            migrationBuilder.DropIndex(
                name: "IX_Houses_ModeId",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "ModeId",
                table: "Houses");

            migrationBuilder.AddColumn<string>(
                name: "Mode",
                table: "Houses",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
