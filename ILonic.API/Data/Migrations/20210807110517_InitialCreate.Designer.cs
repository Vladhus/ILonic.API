﻿// <auto-generated />
using System;
using ILonic.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ILonic.API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210807110517_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("ILonic.API.Entities.TempData", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Amount")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Number")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("TempDatas");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Amount = 5,
                            Date = new DateTime(2021, 8, 7, 13, 5, 16, 769, DateTimeKind.Local).AddTicks(4361),
                            Number = "48 794 559 395"
                        },
                        new
                        {
                            ID = 2,
                            Amount = 9,
                            Date = new DateTime(2021, 8, 7, 13, 5, 16, 771, DateTimeKind.Local).AddTicks(5877),
                            Number = "48 794 559 395"
                        },
                        new
                        {
                            ID = 3,
                            Amount = 10,
                            Date = new DateTime(2021, 8, 7, 13, 5, 16, 771, DateTimeKind.Local).AddTicks(5935),
                            Number = "48 794 559 395"
                        },
                        new
                        {
                            ID = 4,
                            Amount = 11,
                            Date = new DateTime(2021, 8, 7, 13, 5, 16, 771, DateTimeKind.Local).AddTicks(5941),
                            Number = "48 794 559 395"
                        },
                        new
                        {
                            ID = 5,
                            Amount = 29,
                            Date = new DateTime(2021, 8, 7, 13, 5, 16, 771, DateTimeKind.Local).AddTicks(5944),
                            Number = "48 794 559 395"
                        });
                });

            modelBuilder.Entity("ILonic.API.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}