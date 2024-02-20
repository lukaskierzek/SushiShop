﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SushiShopAngular.Server.Data;

#nullable disable

namespace SushiShopAngular.Server.Migrations
{
    [DbContext(typeof(SushiShopContext))]
    [Migration("20240220104742_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IngredientSushi", b =>
                {
                    b.Property<int>("IngredientsId")
                        .HasColumnType("int");

                    b.Property<int>("SushisId")
                        .HasColumnType("int");

                    b.HasKey("IngredientsId", "SushisId");

                    b.HasIndex("SushisId");

                    b.ToTable("IngredientSushi");
                });

            modelBuilder.Entity("SubCategorySushi", b =>
                {
                    b.Property<int>("SubCategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("SushisId")
                        .HasColumnType("int");

                    b.HasKey("SubCategoriesId", "SushisId");

                    b.HasIndex("SushisId");

                    b.ToTable("SubCategorySushi");
                });

            modelBuilder.Entity("SushiShopAngular.Server.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleted")
                        .HasMaxLength(1)
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("SushiShopAngular.Server.Models.MainCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleted")
                        .HasMaxLength(1)
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("MainCategories");
                });

            modelBuilder.Entity("SushiShopAngular.Server.Models.SubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleted")
                        .HasMaxLength(1)
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("SushiShopAngular.Server.Models.Sushi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("ActualPrice")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleted")
                        .HasMaxLength(1)
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("MainCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("OldPrice")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("Id");

                    b.HasIndex("MainCategoryId");

                    b.ToTable("Sushis");
                });

            modelBuilder.Entity("SushiShopAngular.Server.Models.SushiDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("IsDeleted")
                        .HasMaxLength(1)
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SushiId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SushiId")
                        .IsUnique()
                        .HasFilter("[SushiId] IS NOT NULL");

                    b.ToTable("SushisDescriptions");
                });

            modelBuilder.Entity("IngredientSushi", b =>
                {
                    b.HasOne("SushiShopAngular.Server.Models.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("IngredientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SushiShopAngular.Server.Models.Sushi", null)
                        .WithMany()
                        .HasForeignKey("SushisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SubCategorySushi", b =>
                {
                    b.HasOne("SushiShopAngular.Server.Models.SubCategory", null)
                        .WithMany()
                        .HasForeignKey("SubCategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SushiShopAngular.Server.Models.Sushi", null)
                        .WithMany()
                        .HasForeignKey("SushisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SushiShopAngular.Server.Models.Sushi", b =>
                {
                    b.HasOne("SushiShopAngular.Server.Models.MainCategory", "MainCategory")
                        .WithMany("Sushis")
                        .HasForeignKey("MainCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MainCategory");
                });

            modelBuilder.Entity("SushiShopAngular.Server.Models.SushiDescription", b =>
                {
                    b.HasOne("SushiShopAngular.Server.Models.Sushi", "Sushi")
                        .WithOne("Description")
                        .HasForeignKey("SushiShopAngular.Server.Models.SushiDescription", "SushiId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Sushi");
                });

            modelBuilder.Entity("SushiShopAngular.Server.Models.MainCategory", b =>
                {
                    b.Navigation("Sushis");
                });

            modelBuilder.Entity("SushiShopAngular.Server.Models.Sushi", b =>
                {
                    b.Navigation("Description");
                });
#pragma warning restore 612, 618
        }
    }
}