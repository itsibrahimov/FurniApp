using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Shop
    {
        [Key]
        public int ProductID { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public bool ProductStatus { get; set; }
        public string ProductPrice { get; set; }

    }
}
