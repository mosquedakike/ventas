using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SaleDetailEntity
    {
        [Key]
        public int SaleDetailId { get; set; }

        //Relacion con BrandEntity
        public int BrandId { get; set; }

        [StringLength(100)]
        public string BrandName { get; set; }

        //Relacion con Employee
        public int EmployeeId { get; set; }

        public EmployeeEntity Employee { get; set; }

        //Relacion con ProducEntity
        public int ProductId { get; set; }

        [StringLength(80)]
        public string ProductName { get; set; }

        [StringLength(600)]
        public string ProductDescription { get; set; }

        public ProductEntity Product { get; set; }

        public int Quantity { get; set; }

        public DateTime SaleDate { get; set; }

        public DateTime RegistrationDate { get; set; }


    }
}
