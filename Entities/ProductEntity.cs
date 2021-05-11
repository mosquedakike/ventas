﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class ProductEntity
    {
        [Key]
        public int ProductId { get; set; }

        [StringLength(80)]
        public string ProductName { get; set; }

        [StringLength(100)]
        public string ProductDescription { get; set; }

    }
}
