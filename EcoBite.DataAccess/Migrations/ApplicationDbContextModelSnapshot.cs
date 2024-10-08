﻿// <auto-generated />
using System;
using EcoBiteBook.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcoBiteBook.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EcoBiteBook.Models.Fooditem", b =>
                {
                    b.Property<int>("FooditemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FooditemId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpirationDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("FooditemId");

                    b.ToTable("Fooditems");

                    b.HasData(
                        new
                        {
                            FooditemId = 1,
                            Description = "Available",
                            ExpirationDate = "29 days",
                            Name = "Rice"
                        },
                        new
                        {
                            FooditemId = 2,
                            Description = "Availabel",
                            ExpirationDate = "5 days",
                            Name = "Burger"
                        });
                });

            modelBuilder.Entity("EcoBiteBook.Models.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InventoryId"));

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("InventoryId");

                    b.ToTable("Inventories");

                    b.HasData(
                        new
                        {
                            InventoryId = 1,
                            DateAdded = new DateTime(2024, 10, 6, 12, 32, 29, 312, DateTimeKind.Local).AddTicks(9352),
                            Quantity = 50
                        },
                        new
                        {
                            InventoryId = 2,
                            DateAdded = new DateTime(2024, 10, 5, 12, 32, 29, 312, DateTimeKind.Local).AddTicks(9364),
                            Quantity = 30
                        },
                        new
                        {
                            InventoryId = 3,
                            DateAdded = new DateTime(2024, 10, 4, 12, 32, 29, 312, DateTimeKind.Local).AddTicks(9370),
                            Quantity = 100
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
