using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Veeya.Migrations
{
    public partial class AddIdToModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Investors_Wholesalers_WholesalerId",
                table: "Investors");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Wholesalers_WholesalerId",
                table: "Properties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Wholesalers",
                table: "Wholesalers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Properties",
                table: "Properties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Investors",
                table: "Investors");

            migrationBuilder.DropColumn(
                name: "id",
                table: "Wholesalers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "id",
                table: "Investors");

            migrationBuilder.AddColumn<int>(
                name: "WholesalerId",
                table: "Wholesalers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "PropertyId",
                table: "Properties",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "WholesalerId",
                table: "Investors",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "InvestorId",
                table: "Investors",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Wholesalers",
                table: "Wholesalers",
                column: "WholesalerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Properties",
                table: "Properties",
                column: "PropertyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Investors",
                table: "Investors",
                column: "InvestorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Investors_Wholesalers_WholesalerId",
                table: "Investors",
                column: "WholesalerId",
                principalTable: "Wholesalers",
                principalColumn: "WholesalerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Wholesalers_WholesalerId",
                table: "Properties",
                column: "WholesalerId",
                principalTable: "Wholesalers",
                principalColumn: "WholesalerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Investors_Wholesalers_WholesalerId",
                table: "Investors");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Wholesalers_WholesalerId",
                table: "Properties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Wholesalers",
                table: "Wholesalers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Properties",
                table: "Properties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Investors",
                table: "Investors");

            migrationBuilder.DropColumn(
                name: "WholesalerId",
                table: "Wholesalers");

            migrationBuilder.DropColumn(
                name: "PropertyId",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "InvestorId",
                table: "Investors");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "Wholesalers",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Properties",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "WholesalerId",
                table: "Investors",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "Investors",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Wholesalers",
                table: "Wholesalers",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Properties",
                table: "Properties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Investors",
                table: "Investors",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Investors_Wholesalers_WholesalerId",
                table: "Investors",
                column: "WholesalerId",
                principalTable: "Wholesalers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Wholesalers_WholesalerId",
                table: "Properties",
                column: "WholesalerId",
                principalTable: "Wholesalers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
