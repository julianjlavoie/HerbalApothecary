﻿// <auto-generated />
using HerbalApothecary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HerbalApothecary.Migrations
{
    [DbContext(typeof(HerbContext))]
    partial class HerbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("HerbalApothecary.Models.Herb", b =>
                {
                    b.Property<int>("HerbId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Actions")
                        .HasColumnType("TEXT");

                    b.Property<string>("BotanicalName")
                        .HasColumnType("TEXT");

                    b.Property<string>("CommonName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Contraindications")
                        .HasColumnType("TEXT");

                    b.Property<string>("Decoction")
                        .HasColumnType("TEXT");

                    b.Property<string>("Energy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<string>("KeyConstituents")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("PartsUsed")
                        .HasColumnType("TEXT");

                    b.Property<string>("Powder")
                        .HasColumnType("TEXT");

                    b.Property<string>("Referances")
                        .HasColumnType("TEXT");

                    b.Property<string>("ResearchFindings")
                        .HasColumnType("TEXT");

                    b.Property<string>("Safety")
                        .HasColumnType("TEXT");

                    b.Property<string>("SideEffects")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tincture")
                        .HasColumnType("TEXT");

                    b.Property<string>("Uses")
                        .HasColumnType("TEXT");

                    b.HasKey("HerbId");

                    b.ToTable("Herbs");
                });

            modelBuilder.Entity("HerbalApothecary.Models.InventoryItem", b =>
                {
                    b.Property<int>("InventoryItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("HerbId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Quantity")
                        .HasColumnType("REAL");

                    b.HasKey("InventoryItemId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("HerbalApothecary.Models.Purchase", b =>
                {
                    b.Property<int>("PurchaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("HerbId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InventoryItemId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("PriceMetric")
                        .HasColumnType("TEXT");

                    b.Property<string>("Vendor")
                        .HasColumnType("TEXT");

                    b.HasKey("PurchaseId");

                    b.ToTable("Purchases");
                });
#pragma warning restore 612, 618
        }
    }
}
