﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using user_mgt.Data;

#nullable disable

namespace user_mgt.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240920092910_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("user_mgt.Models.Domains.BoardingOwner", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("BoardingOwners");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("88aebc5b-1cf1-4323-bc47-148c83fc4766"),
                            Email = "lahirunanayakkara@gmail.com",
                            FullName = "Lahiru Nanayakkara",
                            IsActive = true,
                            LastLogin = new DateTime(2024, 9, 20, 14, 59, 9, 548, DateTimeKind.Local).AddTicks(8815),
                            Password = "12345678",
                            Phone = "0760944045",
                            RegistrationDate = new DateTime(2024, 9, 20, 14, 59, 9, 548, DateTimeKind.Local).AddTicks(8804),
                            Role = "BoardingOwner"
                        });
                });

            modelBuilder.Entity("user_mgt.Models.Domains.Student", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Webmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("c8a6e6ef-3fdd-4d7b-a150-916d33f48113"),
                            FullName = "Nanayakkara omll",
                            IsActive = true,
                            LastLogin = new DateTime(2024, 9, 20, 14, 59, 9, 548, DateTimeKind.Local).AddTicks(8994),
                            Password = "Lahiru#1",
                            RegistrationDate = new DateTime(2024, 9, 20, 14, 59, 9, 548, DateTimeKind.Local).AddTicks(8993),
                            Role = "Student",
                            Webmail = "nanayakkaraomll.21@uom.lk"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}