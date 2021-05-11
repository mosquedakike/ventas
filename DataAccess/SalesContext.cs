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
        public DbSet<SaleDetailEntity> SaleDateils { get; set; }

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
                new BrandEntity { BrandId=1, BrandName="Quaker State", BrandProject="Promotoria" }
                );

            modelBuilder.Entity<EmployeeEntity>().HasData(
                new EmployeeEntity { EmployeeId=1, EmployeeName="Andres Manuel", EmployeeLastName="Lopez", EmployeeLastName_2="Obrador", EmployeePosition="Vendedor", Project="Promotoria" }
                );
        }
    }
}
