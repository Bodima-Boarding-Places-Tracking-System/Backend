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
    [Migration("20241014152719_init")]
    partial class init
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

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                            UserId = new Guid("1d496ba5-5a36-4ff7-bded-2342bb3b6baf"),
                            Email = "lahirunanayakkara@gmail.com",
                            FirstName = "Lahiru",
                            IsActive = true,
                            IsAdmin = true,
                            LastLogin = new DateTime(2024, 10, 14, 20, 57, 16, 181, DateTimeKind.Local).AddTicks(1784),
                            LastName = "Nanayakkara",
                            Password = "12345678",
                            Phone = "0760944045",
                            RegistrationDate = new DateTime(2024, 10, 14, 20, 57, 16, 181, DateTimeKind.Local).AddTicks(1765),
                            Role = "BoardingOwner"
                        });
                });

            modelBuilder.Entity("user_mgt.Models.Domains.Student", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                            UserId = new Guid("cecb3eb7-5dc7-44d4-b440-99f059c60c07"),
                            FirstName = "Lahiru",
                            IsActive = true,
                            IsAdmin = true,
                            LastLogin = new DateTime(2024, 10, 14, 20, 57, 16, 181, DateTimeKind.Local).AddTicks(2059),
                            LastName = "Nanayakkara",
                            Password = "+i7b14TZoXcFHDfIGw8b3g==;U5uWa6FpNeUamE6v5EVntc/nvlqGCDGe7tXLBlxz4t0=",
                            RegistrationDate = new DateTime(2024, 10, 14, 20, 57, 16, 181, DateTimeKind.Local).AddTicks(2057),
                            Role = "Student",
                            Webmail = "example.21@uom.lk"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
