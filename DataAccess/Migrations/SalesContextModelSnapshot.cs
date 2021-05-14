﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(SalesContext))]
    partial class SalesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.BrandEntity", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("BrandProject")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("BrandId");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            BrandId = 1,
                            BrandName = "Quaker State",
                            BrandProject = "Promotoria Quaker",
                            Status = true
                        },
                        new
                        {
                            BrandId = 2,
                            BrandName = "Liverpool",
                            BrandProject = "Promotoria",
                            Status = false
                        });
                });

            modelBuilder.Entity("Entities.EmployeeEntity", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeLastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("EmployeeLastName_2")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("EmployeePosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("EmployeeId");

                    b.HasIndex("BrandId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            BrandId = 1,
                            EmployeeLastName = "Lopez",
                            EmployeeLastName_2 = "Obrador",
                            EmployeeName = "Andres Manuel",
                            EmployeePosition = "Vendedor",
                            Status = true
                        },
                        new
                        {
                            EmployeeId = 2,
                            BrandId = 1,
                            EmployeeLastName = "Navarrete",
                            EmployeeLastName_2 = "Hernandez",
                            EmployeeName = "Miguel",
                            EmployeePosition = "Vendedor",
                            Status = true
                        });
                });

            modelBuilder.Entity("Entities.ProductEntity", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Brand = "Quaker State",
                            ProductDescription = "25W50",
                            ProductName = "QS MAXIMA VISCOSIDAD SAE 25W50 CF4",
                            Status = true
                        },
                        new
                        {
                            ProductId = 2,
                            Brand = "Quaker State",
                            ProductDescription = "Anticongelante",
                            ProductName = "ANTICONGELANTE CONCENTRACION IDEAL",
                            Status = true
                        },
                        new
                        {
                            ProductId = 3,
                            Brand = "Quaker State",
                            ProductDescription = "GREEN OIL",
                            ProductName = "QS GREEN OIL SAE 140",
                            Status = true
                        });
                });

            modelBuilder.Entity("Entities.SaleEntity", b =>
                {
                    b.Property<int>("SaleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("ProductDescriptionSale")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductNameSale")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("SaleDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SaleDateUser")
                        .HasColumnType("datetime2");

                    b.HasKey("SaleId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProductId");

                    b.ToTable("Sales");

                    b.HasData(
                        new
                        {
                            SaleId = 1,
                            EmployeeId = 1,
                            ProductDescriptionSale = "25W50",
                            ProductId = 1,
                            ProductNameSale = "QS MAXIMA VISCOSIDAD SAE 25W50 CF4",
                            Quantity = 18,
                            SaleDate = new DateTime(2021, 5, 13, 16, 37, 20, 864, DateTimeKind.Local).AddTicks(7033),
                            SaleDateUser = new DateTime(2021, 5, 13, 16, 37, 20, 860, DateTimeKind.Local).AddTicks(7875)
                        },
                        new
                        {
                            SaleId = 2,
                            EmployeeId = 2,
                            ProductDescriptionSale = "GREEN OIL",
                            ProductId = 3,
                            ProductNameSale = "QS GREEN OIL SAE 140",
                            Quantity = 50,
                            SaleDate = new DateTime(2021, 5, 13, 16, 37, 20, 864, DateTimeKind.Local).AddTicks(8079),
                            SaleDateUser = new DateTime(2021, 5, 13, 16, 37, 20, 864, DateTimeKind.Local).AddTicks(8056)
                        },
                        new
                        {
                            SaleId = 3,
                            EmployeeId = 2,
                            ProductDescriptionSale = "Anticongelante",
                            ProductId = 2,
                            ProductNameSale = "ANTICONGELANTE CONCENTRACION IDEAL",
                            Quantity = 2,
                            SaleDate = new DateTime(2021, 5, 13, 16, 37, 20, 864, DateTimeKind.Local).AddTicks(8090),
                            SaleDateUser = new DateTime(2021, 5, 13, 16, 37, 20, 864, DateTimeKind.Local).AddTicks(8086)
                        },
                        new
                        {
                            SaleId = 4,
                            EmployeeId = 2,
                            ProductDescriptionSale = "Anticongelante",
                            ProductId = 2,
                            ProductNameSale = "ANTICONGELANTE CONCENTRACION IDEAL",
                            Quantity = 5,
                            SaleDate = new DateTime(2021, 5, 13, 16, 37, 20, 864, DateTimeKind.Local).AddTicks(8098),
                            SaleDateUser = new DateTime(2021, 5, 13, 16, 37, 20, 864, DateTimeKind.Local).AddTicks(8094)
                        },
                        new
                        {
                            SaleId = 5,
                            EmployeeId = 1,
                            ProductDescriptionSale = "25W50",
                            ProductId = 1,
                            ProductNameSale = "QS MAXIMA VISCOSIDAD SAE 25W50 CF4",
                            Quantity = 87,
                            SaleDate = new DateTime(2021, 5, 13, 16, 37, 20, 864, DateTimeKind.Local).AddTicks(8107),
                            SaleDateUser = new DateTime(2021, 5, 13, 16, 37, 20, 864, DateTimeKind.Local).AddTicks(8103)
                        });
                });

            modelBuilder.Entity("Entities.EmployeeEntity", b =>
                {
                    b.HasOne("Entities.BrandEntity", "Brand")
                        .WithMany("Employees")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("Entities.SaleEntity", b =>
                {
                    b.HasOne("Entities.EmployeeEntity", "Employee")
                        .WithMany("Sales")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.ProductEntity", "Product")
                        .WithMany("Sales")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Entities.BrandEntity", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Entities.EmployeeEntity", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("Entities.ProductEntity", b =>
                {
                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}
