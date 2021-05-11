using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class SaleDetailEntity
    {
        [Key]
        public int SaleDetailId { get; set; }

        //Relacion con ProducEntity

        [StringLength(80)]
        public string ProductName { get; set; }

        [StringLength(600)]
        public string ProductDescription { get; set; }

        public ProductEntity Product { get; set; }

        public int Quantity { get; set; }

        public DateTime SaleDate { get; set; }

        public DateTime RegistrationDate { get; set; }

        //Relacion con BrandEntity
        [StringLength(100)]
        public string BrandName { get; set; }
    }
}
