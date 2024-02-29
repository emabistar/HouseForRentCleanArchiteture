﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArchitectureHouse.Migrations
{
    /// <inheritdoc />
    public partial class ThirdCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Houses_Modes_ModeId",
                table: "Houses");

            migrationBuilder.AlterColumn<int>(
                name: "ModeId",
                table: "Houses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AlterColumn<int>(
                name: "ModeId",
                table: "Houses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_Modes_ModeId",
                table: "Houses",
                column: "ModeId",
                principalTable: "Modes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
