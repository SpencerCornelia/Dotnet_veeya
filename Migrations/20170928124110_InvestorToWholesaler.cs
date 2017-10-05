using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Veeya.Migrations
{
    public partial class InvestorToWholesaler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "InvestorToWholesalers",
                columns: table => new
                {
                    InvestorId = table.Column<int>(type: "int", nullable: false),
                    InvestorId2 = table.Column<int>(type: "int", nullable: true),
                    WholesalerId = table.Column<int>(type: "int", nullable: false),
                    WholesalerId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvestorToWholesalers", x => x.InvestorId);
                    table.ForeignKey(
                        name: "FK_InvestorToWholesalers_Investors_InvestorId",
                        column: x => x.InvestorId,
                        principalTable: "Investors",
                        principalColumn: "InvestorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvestorToWholesalers_Investors_InvestorId2",
                        column: x => x.InvestorId2,
                        principalTable: "Investors",
                        principalColumn: "InvestorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvestorToWholesalers_Wholesalers_WholesalerId",
                        column: x => x.WholesalerId,
                        principalTable: "Wholesalers",
                        principalColumn: "WholesalerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvestorToWholesalers_Wholesalers_WholesalerId1",
                        column: x => x.WholesalerId1,
                        principalTable: "Wholesalers",
                        principalColumn: "WholesalerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvestorToWholesalers_InvestorId2",
                table: "InvestorToWholesalers",
                column: "InvestorId2");

            migrationBuilder.CreateIndex(
                name: "IX_InvestorToWholesalers_WholesalerId",
                table: "InvestorToWholesalers",
                column: "WholesalerId");

            migrationBuilder.CreateIndex(
                name: "IX_InvestorToWholesalers_WholesalerId1",
                table: "InvestorToWholesalers",
                column: "WholesalerId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvestorToWholesalers");

            migrationBuilder.AddColumn<int>(
                name: "WholesalerId",
                table: "Investors",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Investors_WholesalerId",
                table: "Investors",
                column: "WholesalerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Investors_Wholesalers_WholesalerId",
                table: "Investors",
                column: "WholesalerId",
                principalTable: "Wholesalers",
                principalColumn: "WholesalerId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
