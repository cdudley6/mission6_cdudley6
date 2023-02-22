﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mission6_cdudley6.Models;

namespace mission6_cdudley6.Migrations
{
    [DbContext(typeof(DateApplicationContext))]
    [Migration("20230222180049_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("mission6_cdudley6.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lent")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("ApplicationId");

                    b.HasIndex("CategoryId");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            ApplicationId = 1,
                            CategoryId = 1,
                            Director = "Keenan Peele",
                            Edited = false,
                            Rating = "R",
                            Title = "Get Out",
                            Year = 2017
                        },
                        new
                        {
                            ApplicationId = 2,
                            CategoryId = 2,
                            Director = "David Fincher",
                            Edited = false,
                            Rating = "R",
                            Title = "Fight Club",
                            Year = 1998
                        },
                        new
                        {
                            ApplicationId = 3,
                            CategoryId = 2,
                            Director = "Christopher Nolan",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Dark Knight",
                            Year = 2011
                        });
                });

            modelBuilder.Entity("mission6_cdudley6.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categorys");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Thriller"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Action"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Comedy"
                        });
                });

            modelBuilder.Entity("mission6_cdudley6.Models.ApplicationResponse", b =>
                {
                    b.HasOne("mission6_cdudley6.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}