﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Veeya.Persistence;

namespace Veeya.Migrations
{
    [DbContext(typeof(VeeyaDbContext))]
    [Migration("20171002014209_UpdateProperty")]
    partial class UpdateProperty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Veeya.Models.Investor", b =>
                {
                    b.Property<int>("InvestorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email_Address")
                        .IsRequired();

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Phone_Number")
                        .IsRequired();

                    b.HasKey("InvestorId");

                    b.ToTable("Investors");
                });

            modelBuilder.Entity("Veeya.Models.InvestorToWholesaler", b =>
                {
                    b.Property<int>("InvestorId");

                    b.Property<int?>("InvestorId2");

                    b.Property<int>("WholesalerId");

                    b.Property<int?>("WholesalerId1");

                    b.HasKey("InvestorId");

                    b.HasIndex("InvestorId2");

                    b.HasIndex("WholesalerId");

                    b.HasIndex("WholesalerId1");

                    b.ToTable("InvestorToWholesalers");
                });

            modelBuilder.Entity("Veeya.Models.Property", b =>
                {
                    b.Property<int>("PropertyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("AfterRepairValue");

                    b.Property<int>("AverageRent");

                    b.Property<int>("Bathrooms");

                    b.Property<int>("Bedrooms");

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("PropertyType")
                        .IsRequired();

                    b.Property<int>("PurchasePrice");

                    b.Property<int>("RehabCostMax");

                    b.Property<int>("RehabCostMin");

                    b.Property<int>("SquareFootage");

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<int>("WholesalerId");

                    b.Property<int>("YearBuilt");

                    b.Property<int>("ZipCode");

                    b.HasKey("PropertyId");

                    b.HasIndex("WholesalerId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("Veeya.Models.Wholesaler", b =>
                {
                    b.Property<int>("WholesalerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("WholesalerId");

                    b.ToTable("Wholesalers");
                });

            modelBuilder.Entity("Veeya.Models.InvestorToWholesaler", b =>
                {
                    b.HasOne("Veeya.Models.Investor", "Investor")
                        .WithMany("InvestorToWholesalers")
                        .HasForeignKey("InvestorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Veeya.Models.Investor")
                        .WithMany("Wholesalers")
                        .HasForeignKey("InvestorId2");

                    b.HasOne("Veeya.Models.Wholesaler", "Wholesaler")
                        .WithMany("InvestorToWholesalers")
                        .HasForeignKey("WholesalerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Veeya.Models.Wholesaler")
                        .WithMany("Investors")
                        .HasForeignKey("WholesalerId1");
                });

            modelBuilder.Entity("Veeya.Models.Property", b =>
                {
                    b.HasOne("Veeya.Models.Wholesaler", "Wholesaler")
                        .WithMany("Properties")
                        .HasForeignKey("WholesalerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
