﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Visitor_Management_System.Data;

#nullable disable

namespace VisitorManagementSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Visitor_Management_System.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Visitor_Management_System.Entities.Visit", b =>
                {
                    b.Property<int>("VisitID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VisitID"));

                    b.Property<DateTime>("CheckInTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CheckOutTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("PersonVisitedID")
                        .HasColumnType("int");

                    b.Property<int>("VisitorID")
                        .HasColumnType("int");

                    b.HasKey("VisitID");

                    b.HasIndex("PersonVisitedID");

                    b.HasIndex("VisitorID");

                    b.ToTable("Visits");
                });

            modelBuilder.Entity("Visitor_Management_System.Entities.Visitor", b =>
                {
                    b.Property<int>("VisitorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VisitorId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CheckInTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CheckOutTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonVisitedId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VisitorId");

                    b.ToTable("Visitors");
                });

            modelBuilder.Entity("Visitor_Management_System.Entities.Visit", b =>
                {
                    b.HasOne("Visitor_Management_System.Entities.User", "PersonVisited")
                        .WithMany("Visits")
                        .HasForeignKey("PersonVisitedID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Visitor_Management_System.Entities.Visitor", "Visitor")
                        .WithMany("Visits")
                        .HasForeignKey("VisitorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonVisited");

                    b.Navigation("Visitor");
                });

            modelBuilder.Entity("Visitor_Management_System.Entities.User", b =>
                {
                    b.Navigation("Visits");
                });

            modelBuilder.Entity("Visitor_Management_System.Entities.Visitor", b =>
                {
                    b.Navigation("Visits");
                });
#pragma warning restore 612, 618
        }
    }
}
