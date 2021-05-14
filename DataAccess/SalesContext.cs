using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SalesContext : DbContext
    {
        public DbSet<BrandEntity> Brands { get; set; }
        public DbSet<EmployeeEntity> Employees { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<SaleEntity> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {
            if (!option.IsConfigured)
            {
                //GONET
                option.UseSqlServer("Server=DESKTOP-KNH5RLA; Database=VentasDb; User Id=sa; Password=2115");

                //NZXT
                //option.UseSqlServer("Server=DESKTOP-8BEJDCB; Database=VentasDb; User Id=sa; Password=2115");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BrandEntity>().HasData(
                new BrandEntity { BrandId=1, BrandName="Quaker State", BrandProject="Promotoria Quaker", Status=true },
                new BrandEntity { BrandId = 2, BrandName = "Liverpool", BrandProject = "Promotoria", Status = false }
                );

            modelBuilder.Entity<EmployeeEntity>().HasData(
                new EmployeeEntity { EmployeeId=1, EmployeeName="Andres Manuel", EmployeeLastName="Lopez", EmployeeLastName_2="Obrador", BrandId=1, EmployeePosition="Vendedor", Status=true },
                new EmployeeEntity { EmployeeId = 2, EmployeeName = "Miguel", EmployeeLastName = "Navarrete", EmployeeLastName_2 = "Hernandez", BrandId = 1, EmployeePosition = "Vendedor", Status = true }
                );

            modelBuilder.Entity<ProductEntity>().HasData(
                new ProductEntity { ProductId=1, ProductName= "QS MAXIMA VISCOSIDAD SAE 25W50 CF4", ProductDescription= "25W50", Brand="Quaker State", Status=true },
                new ProductEntity { ProductId = 2, ProductName = "ANTICONGELANTE CONCENTRACION IDEAL", ProductDescription = "Anticongelante", Brand = "Quaker State", Status = true },
                new ProductEntity { ProductId = 3, ProductName = "QS GREEN OIL SAE 140", ProductDescription = "GREEN OIL", Brand = "Quaker State", Status = true }
                );

            modelBuilder.Entity<SaleEntity>().HasData(
                new SaleEntity { SaleId = 1, ProductId = 1, EmployeeId = 1, ProductNameSale = "QS MAXIMA VISCOSIDAD SAE 25W50 CF4", ProductDescriptionSale = "25W50", Quantity = 18, SaleDateUser = DateTime.Now, SaleDate = DateTime.Now },
                new SaleEntity { SaleId = 2, ProductId = 3, EmployeeId = 2, ProductNameSale = "QS GREEN OIL SAE 140",  ProductDescriptionSale = "GREEN OIL", Quantity = 50, SaleDateUser = DateTime.Now, SaleDate = DateTime.Now },
                new SaleEntity { SaleId = 3, ProductId = 2, EmployeeId = 2, ProductNameSale = "ANTICONGELANTE CONCENTRACION IDEAL", ProductDescriptionSale = "Anticongelante", Quantity = 2, SaleDateUser = DateTime.Now, SaleDate = DateTime.Now },
                new SaleEntity { SaleId = 4, ProductId = 2, EmployeeId = 2, ProductNameSale = "ANTICONGELANTE CONCENTRACION IDEAL", ProductDescriptionSale = "Anticongelante", Quantity = 5, SaleDateUser = DateTime.Now, SaleDate = DateTime.Now },
                new SaleEntity { SaleId = 5, ProductId = 1, EmployeeId = 1, ProductNameSale = "QS MAXIMA VISCOSIDAD SAE 25W50 CF4", ProductDescriptionSale = "25W50", Quantity = 87, SaleDateUser = DateTime.Now, SaleDate = DateTime.Now }
                );
        }
    }
}
