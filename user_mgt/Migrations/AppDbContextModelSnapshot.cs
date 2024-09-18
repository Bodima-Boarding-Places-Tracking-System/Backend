﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using user_mgt.Data;

#nullable disable

namespace user_mgt.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            UserId = new Guid("c309f0c1-d63f-4a23-b99f-2af8adc01520"),
                            Email = "lahirunanayakkara@gmail.com",
                            FullName = "Lahiru Nanayakkara",
                            IsActive = true,
                            LastLogin = new DateTime(2024, 9, 18, 5, 7, 18, 462, DateTimeKind.Local).AddTicks(8024),
                            Password = "12345678",
                            Phone = "0760944045",
                            RegistrationDate = new DateTime(2024, 9, 18, 5, 7, 18, 462, DateTimeKind.Local).AddTicks(8012),
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
                            UserId = new Guid("82e29a8a-12b3-4aea-94ba-8f191b9235ea"),
                            FullName = "Nanayakkara omll",
                            IsActive = true,
                            LastLogin = new DateTime(2024, 9, 18, 5, 7, 18, 462, DateTimeKind.Local).AddTicks(8136),
                            Password = "Lahiru#1",
                            RegistrationDate = new DateTime(2024, 9, 18, 5, 7, 18, 462, DateTimeKind.Local).AddTicks(8136),
                            Role = "Student",
                            Webmail = "nanayakkaraomll.21@uom.lk"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
