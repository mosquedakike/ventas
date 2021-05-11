using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BrandEntity
    {
        [Key]
        public int BrandId { get; set; }

        [StringLength(100)]
        public string BrandName { get; set; }

        [StringLength(100)]
        public string BrandProject { get; set; }

        //Relacion con SaleDetails
        public ICollection<SaleDetailEntity> SaleDetails { get; set; }

    }
}
