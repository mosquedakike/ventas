using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EmployeeEntity
    {
        [Key]
        public int EmployeeId { get; set; }

        [StringLength(30)]
        public string EmployeeName { get; set; }

        [StringLength(30)]
        public string EmployeeLastName { get; set; }

        [StringLength(30)]
        public string EmployeeLastName_2 { get; set; }

        //Relacion con BrandEntity
        public int BrandId { get; set; }

        public BrandEntity Brand { get; set; }

        public string EmployeePosition { get; set; }

        public bool Status { get; set; }

        //Relacion con SaleEntity
        public ICollection<SaleEntity> Sales { get; set; }
    }
}
