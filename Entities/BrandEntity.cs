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

        [Required]
        [StringLength(100)]
        public string BrandName { get; set; }

        [Required]
        [StringLength(100)]
        public string BrandProject { get; set; }

        public bool Status { get; set; }

        //Relacion con SaleDetails
        public ICollection<EmployeeEntity> Employees { get; set; }

    }
}
