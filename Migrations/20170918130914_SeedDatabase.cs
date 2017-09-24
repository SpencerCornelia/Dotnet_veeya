using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Veeya.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Wholesalers (First_Name) Values ('Spencer')");
            migrationBuilder.Sql("INSERT INTO Wholesalers (First_Name) Values ('Thomas')");
            migrationBuilder.Sql("INSERT INTO Wholesalers (First_Name) Values ('Debbie')");

            migrationBuilder.Sql("INSERT INTO Properties (AddressName, WholesalerId) Values ('723 Oakmont Ave', (SELECT ID FROM Wholesalers WHERE First_Name = 'Spencer'))");
            migrationBuilder.Sql("INSERT INTO Properties (AddressName, WholesalerId) Values ('1010 Hardwood Hollow', (SELECT ID FROM Wholesalers WHERE First_Name = 'Spencer'))");
            migrationBuilder.Sql("INSERT INTO Properties (AddressName, WholesalerId) Values ('120 Main Street', (SELECT ID FROM Wholesalers WHERE First_Name = 'Spencer'))");
        
            migrationBuilder.Sql("INSERT INTO Properties (AddressName, WholesalerId) Values ('789 Paper Street', (SELECT ID FROM Wholesalers WHERE First_Name = 'Thomas'))");
            migrationBuilder.Sql("INSERT INTO Properties (AddressName, WholesalerId) Values ('1 Remote Way', (SELECT ID FROM Wholesalers WHERE First_Name = 'Thomas'))");
            migrationBuilder.Sql("INSERT INTO Properties (AddressName, WholesalerId) Values ('555 Telephone Street', (SELECT ID FROM Wholesalers WHERE First_Name = 'Thomas'))");

            migrationBuilder.Sql("INSERT INTO Properties (AddressName, WholesalerId) Values ('111 DreamChasing Way', (SELECT ID FROM Wholesalers WHERE First_Name = 'Debbie'))");
            migrationBuilder.Sql("INSERT INTO Properties (AddressName, WholesalerId) Values ('222 Never Give Up St', (SELECT ID FROM Wholesalers WHERE First_Name = 'Debbie'))");
            migrationBuilder.Sql("INSERT INTO Properties (AddressName, WholesalerId) Values ('567 Table Ave', (SELECT ID FROM Wholesalers WHERE First_Name = 'Debbie'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Properties");
            migrationBuilder.Sql("DELETE FROM Wholesalers WHERE First_Name IN ('Spencer', 'Thomas', 'Debbie')");
        }
    }
}
