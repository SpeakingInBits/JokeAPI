﻿// <auto-generated />
using System;
using JokeAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JokeAPI.Migrations
{
    [DbContext(typeof(JokeDbContext))]
    partial class JokeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("JokeAPI.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("JokeAPI.Models.Joke", b =>
                {
                    b.Property<int>("JokeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JokeId"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("JokeText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JokeId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Jokes");
                });

            modelBuilder.Entity("JokeAPI.Models.Joke", b =>
                {
                    b.HasOne("JokeAPI.Models.Category", "Category")
                        .WithMany("Jokes")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("JokeAPI.Models.Category", b =>
                {
                    b.Navigation("Jokes");
                });
#pragma warning restore 612, 618
        }
    }
}