using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Veeya.Migrations
{
    public partial class InvestorHasWholeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WholesalerId",
                table: "Investors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Investors_WholesalerId",
                table: "Investors",
                column: "WholesalerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Investors_Wholesalers_WholesalerId",
                table: "Investors",
                column: "WholesalerId",
                principalTable: "Wholesalers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Investors_Wholesalers_WholesalerId",
                table: "Investors");

            migrationBuilder.DropIndex(
                name: "IX_Investors_WholesalerId",
                table: "Investors");

            migrationBuilder.DropColumn(
                name: "WholesalerId",
                table: "Investors");
        }
    }
}
