﻿// <auto-generated />
using System;
using AppApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240612190455_CreatedCategoryTable")]
    partial class CreatedCategoryTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AppApi.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 6, 12, 23, 4, 55, 423, DateTimeKind.Local).AddTicks(1726),
                            Name = "UI UX"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 12, 23, 4, 55, 423, DateTimeKind.Local).AddTicks(1739),
                            Name = "Programming"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 6, 12, 23, 4, 55, 423, DateTimeKind.Local).AddTicks(1740),
                            Name = "Frontend"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}