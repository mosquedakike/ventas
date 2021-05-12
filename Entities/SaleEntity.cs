using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SaleEntity
    {
        [Key]
        public int SaleId { get; set; }

        //Relacion con ProductEntity
        public int ProductId { get; set; }

        public ProductEntity Product { get; set; }

        //Relacion con Employee
        public int EmployeeId { get; set; }

        public EmployeeEntity Employee { get; set; }

        public int Quantity { get; set; }

        public DateTime SaleDate { get; set; }
    }
}
