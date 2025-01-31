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

                    b.Property<string>("Roles")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("BoardingOwners");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("c9bb1d02-c56e-44a8-98e8-2c706d098ee8"),
                            Email = "lahirunanayakkara@gmail.com",
                            FirstName = "Lahiru",
                            IsActive = true,
                            IsAdmin = true,
                            LastLogin = new DateTime(2024, 10, 26, 18, 6, 42, 824, DateTimeKind.Local).AddTicks(3204),
                            LastName = "Nanayakkara",
                            Password = "12345678",
                            Phone = "0760944045",
                            RegistrationDate = new DateTime(2024, 10, 26, 18, 6, 42, 824, DateTimeKind.Local).AddTicks(3194),
                            Roles = "[\"boarding-owner\",\"admin\"]"
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

                    b.Property<string>("Roles")
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
                            UserId = new Guid("9740b23b-8d88-4454-9988-8eb90dcd35c0"),
                            FirstName = "Lahiru",
                            IsActive = true,
                            IsAdmin = true,
                            LastLogin = new DateTime(2024, 10, 26, 18, 6, 42, 824, DateTimeKind.Local).AddTicks(3315),
                            LastName = "Nanayakkara",
                            Password = "+i7b14TZoXcFHDfIGw8b3g==;U5uWa6FpNeUamE6v5EVntc/nvlqGCDGe7tXLBlxz4t0=",
                            RegistrationDate = new DateTime(2024, 10, 26, 18, 6, 42, 824, DateTimeKind.Local).AddTicks(3314),
                            Roles = "[\"student\",\"admin\"]",
                            Webmail = "example.21@uom.lk"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
