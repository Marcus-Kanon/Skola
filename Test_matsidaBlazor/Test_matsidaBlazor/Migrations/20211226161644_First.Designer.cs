﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test_matsidaBlazor.Data;

#nullable disable

namespace Test_matsidaBlazor.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211226161644_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Test_matsidaBlazor.Data.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Density")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NutrientsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NutrientsId")
                        .IsUnique();

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Test_matsidaBlazor.Data.Models.Nutrients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("VitA")
                        .HasColumnType("float");

                    b.Property<double>("VitB")
                        .HasColumnType("float");

                    b.Property<double>("VitC")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Nutrients");
                });

            modelBuilder.Entity("Test_matsidaBlazor.Data.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("Test_matsidaBlazor.Data.Models.Recipes_Ingredients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.HasIndex("RecipeId");

                    b.ToTable("Recipes_Nutrients");
                });

            modelBuilder.Entity("Test_matsidaBlazor.Data.Models.Ingredient", b =>
                {
                    b.HasOne("Test_matsidaBlazor.Data.Models.Nutrients", "Nutrients")
                        .WithOne("Ingredient")
                        .HasForeignKey("Test_matsidaBlazor.Data.Models.Ingredient", "NutrientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nutrients");
                });

            modelBuilder.Entity("Test_matsidaBlazor.Data.Models.Recipes_Ingredients", b =>
                {
                    b.HasOne("Test_matsidaBlazor.Data.Models.Ingredient", "Ingredient")
                        .WithMany("Recipes_Ingredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Test_matsidaBlazor.Data.Models.Recipe", "Recipe")
                        .WithMany("Recipes_Ingredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("Test_matsidaBlazor.Data.Models.Ingredient", b =>
                {
                    b.Navigation("Recipes_Ingredients");
                });

            modelBuilder.Entity("Test_matsidaBlazor.Data.Models.Nutrients", b =>
                {
                    b.Navigation("Ingredient")
                        .IsRequired();
                });

            modelBuilder.Entity("Test_matsidaBlazor.Data.Models.Recipe", b =>
                {
                    b.Navigation("Recipes_Ingredients");
                });
#pragma warning restore 612, 618
        }
    }
}
