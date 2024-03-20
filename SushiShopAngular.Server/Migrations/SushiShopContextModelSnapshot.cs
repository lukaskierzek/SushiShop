﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SushiShopAngular.Server.Data;

#nullable disable

namespace SushiShopAngular.Server.Migrations
{
    [DbContext(typeof(SushiShopContext))]
    partial class SushiShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4466),
                            IsDeleted = 0,
                            LastModified = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4467),
                            Name = "Ingredient1"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4470),
                            IsDeleted = 0,
                            LastModified = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4470),
                            Name = "Ingredient2"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4473),
                            IsDeleted = 0,
                            LastModified = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4473),
                            Name = "Ingredient3"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4382),
                            IsDeleted = 0,
                            LastModified = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4382),
                            Name = "Main category 1"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4385),
                            IsDeleted = 0,
                            LastModified = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4385),
                            Name = "Main category 2"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4387),
                            IsDeleted = 0,
                            LastModified = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4388),
                            Name = "Main category 3"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4504),
                            IsDeleted = 0,
                            LastModified = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4504),
                            Name = "subCategory1"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4507),
                            IsDeleted = 0,
                            LastModified = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4508),
                            Name = "subCategory2"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4510),
                            IsDeleted = 0,
                            LastModified = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4510),
                            Name = "subCategory3"
                        });
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

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActualPrice = 10m,
                            Created = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4298),
                            ImageUrl = "https://img.freepik.com/free-photo/freshness-plate-gourmet-seafood-maki-sushi-avocado-sashimi-generated-by-artificial-intelligence_25030-66337.jpg?w=1380&t=st=1709289227~exp=1709289827~hmac=b87b76aed267433a4760bd9582f1c8b8ca8564915573edeb67ebf356a0b3eb3f",
                            IsDeleted = 0,
                            LastModified = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4298),
                            MainCategoryId = 1,
                            Name = "Sushi1",
                            OldPrice = 10m
                        },
                        new
                        {
                            Id = 2,
                            ActualPrice = 10m,
                            Created = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4302),
                            ImageUrl = "https://img.freepik.com/free-photo/freshness-plate-gourmet-seafood-maki-sushi-avocado-sashimi-generated-by-artificial-intelligence_25030-66337.jpg?w=1380&t=st=1709289227~exp=1709289827~hmac=b87b76aed267433a4760bd9582f1c8b8ca8564915573edeb67ebf356a0b3eb3f",
                            IsDeleted = 0,
                            LastModified = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4303),
                            MainCategoryId = 2,
                            Name = "Sushi2",
                            OldPrice = 9m
                        },
                        new
                        {
                            Id = 3,
                            ActualPrice = 10m,
                            Created = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4306),
                            ImageUrl = "https://img.freepik.com/free-photo/freshness-plate-gourmet-seafood-maki-sushi-avocado-sashimi-generated-by-artificial-intelligence_25030-66337.jpg?w=1380&t=st=1709289227~exp=1709289827~hmac=b87b76aed267433a4760bd9582f1c8b8ca8564915573edeb67ebf356a0b3eb3f",
                            IsDeleted = 0,
                            LastModified = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4307),
                            MainCategoryId = 3,
                            Name = "Sushi3",
                            OldPrice = 20m
                        },
                        new
                        {
                            Id = 4,
                            ActualPrice = 10m,
                            Created = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4310),
                            ImageUrl = "https://img.freepik.com/free-photo/freshness-plate-gourmet-seafood-maki-sushi-avocado-sashimi-generated-by-artificial-intelligence_25030-66337.jpg?w=1380&t=st=1709289227~exp=1709289827~hmac=b87b76aed267433a4760bd9582f1c8b8ca8564915573edeb67ebf356a0b3eb3f",
                            IsDeleted = 1,
                            LastModified = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4311),
                            MainCategoryId = 3,
                            Name = "Sushi4",
                            OldPrice = 20m
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4422),
                            Description = "SushiDescription1",
                            IsDeleted = 0,
                            LastModified = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4423),
                            SushiId = 1
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4425),
                            Description = "SushiDescription2",
                            IsDeleted = 0,
                            LastModified = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4426),
                            SushiId = 2
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4428),
                            Description = "SushiDescription3",
                            IsDeleted = 0,
                            LastModified = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4428),
                            SushiId = 3
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4431),
                            Description = "SushiDescription4",
                            IsDeleted = 0,
                            LastModified = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4431),
                            SushiId = 4
                        });
                });

            modelBuilder.Entity("SushiShopAngular.Server.Models.SushiIngredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int>("SushiId")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.HasKey("IngredientId", "SushiId");

                    b.HasIndex("SushiId");

                    b.ToTable("SushiIngredients", t =>
                        {
                            t.HasCheckConstraint("CK_SushiIngredient_RangeAmount", "Amount >= 0 AND Amount <=100");
                        });

                    b.HasData(
                        new
                        {
                            IngredientId = 1,
                            SushiId = 1,
                            Amount = 1,
                            Created = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4637),
                            LastModified = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4637)
                        },
                        new
                        {
                            IngredientId = 2,
                            SushiId = 1,
                            Amount = 2,
                            Created = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4639),
                            LastModified = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4640)
                        },
                        new
                        {
                            IngredientId = 1,
                            SushiId = 2,
                            Amount = 3,
                            Created = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4641),
                            LastModified = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4641)
                        });
                });

            modelBuilder.Entity("SushiShopAngular.Server.Models.SushiSubCategory", b =>
                {
                    b.Property<int>("SubCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("SushiId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.HasKey("SubCategoryId", "SushiId");

                    b.HasIndex("SushiId");

                    b.ToTable("SushiSubCategory");

                    b.HasData(
                        new
                        {
                            SubCategoryId = 1,
                            SushiId = 1,
                            Created = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4594)
                        },
                        new
                        {
                            SubCategoryId = 2,
                            SushiId = 1,
                            Created = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4599)
                        },
                        new
                        {
                            SubCategoryId = 1,
                            SushiId = 2,
                            Created = new DateTime(2024, 3, 20, 10, 53, 58, 859, DateTimeKind.Utc).AddTicks(4600)
                        });
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

            modelBuilder.Entity("SushiShopAngular.Server.Models.SushiIngredient", b =>
                {
                    b.HasOne("SushiShopAngular.Server.Models.Ingredient", "Ingredient")
                        .WithMany("sushiIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SushiShopAngular.Server.Models.Sushi", "Sushi")
                        .WithMany("sushiIngredients")
                        .HasForeignKey("SushiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Sushi");
                });

            modelBuilder.Entity("SushiShopAngular.Server.Models.SushiSubCategory", b =>
                {
                    b.HasOne("SushiShopAngular.Server.Models.SubCategory", "SubCategory")
                        .WithMany("sushiSubCategories")
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SushiShopAngular.Server.Models.Sushi", "Sushi")
                        .WithMany("sushiSubCategories")
                        .HasForeignKey("SushiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubCategory");

                    b.Navigation("Sushi");
                });

            modelBuilder.Entity("SushiShopAngular.Server.Models.Ingredient", b =>
                {
                    b.Navigation("sushiIngredients");
                });

            modelBuilder.Entity("SushiShopAngular.Server.Models.MainCategory", b =>
                {
                    b.Navigation("Sushis");
                });

            modelBuilder.Entity("SushiShopAngular.Server.Models.SubCategory", b =>
                {
                    b.Navigation("sushiSubCategories");
                });

            modelBuilder.Entity("SushiShopAngular.Server.Models.Sushi", b =>
                {
                    b.Navigation("Description");

                    b.Navigation("sushiIngredients");

                    b.Navigation("sushiSubCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
