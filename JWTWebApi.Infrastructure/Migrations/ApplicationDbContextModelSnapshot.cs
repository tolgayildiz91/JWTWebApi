﻿// <auto-generated />
using System;
using JWTWebApi.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JWTWebApi.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JWTWebApi.Domain.Entities.Concrete.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "sysAdmin",
                            CreatedDate = new DateTime(2023, 3, 25, 15, 5, 16, 710, DateTimeKind.Local).AddTicks(7373),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "123",
                            Status = 1,
                            UserName = "rido"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "sysAdmin",
                            CreatedDate = new DateTime(2023, 3, 25, 15, 5, 16, 710, DateTimeKind.Local).AddTicks(7376),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "123",
                            Status = 1,
                            UserName = "onder"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "sysAdmin",
                            CreatedDate = new DateTime(2023, 3, 25, 15, 5, 16, 710, DateTimeKind.Local).AddTicks(7377),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "123",
                            Status = 1,
                            UserName = "pelin"
                        });
                });

            modelBuilder.Entity("JWTWebApi.Domain.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "sysAdmin",
                            CreatedDate = new DateTime(2023, 3, 25, 15, 5, 16, 710, DateTimeKind.Local).AddTicks(6989),
                            Description = "sebze",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Gıda",
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "sysAdmin",
                            CreatedDate = new DateTime(2023, 3, 25, 15, 5, 16, 710, DateTimeKind.Local).AddTicks(7000),
                            Description = "pc,tablet",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Teknoloji",
                            Status = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "sysAdmin",
                            CreatedDate = new DateTime(2023, 3, 25, 15, 5, 16, 710, DateTimeKind.Local).AddTicks(7002),
                            Description = "takı toka",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aksesuar",
                            Status = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
