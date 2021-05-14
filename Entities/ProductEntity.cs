using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductEntity
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [StringLength(80)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(600)]
        public string ProductDescription { get; set; }

        [StringLength(100)]
        public string Brand { get; set; }

        public bool Status { get; set; }

        //Relacion con SaleDetailEntity
        public ICollection<SaleEntity> Sales { get; set; }

    }
}
