using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Cart
    {
        [Key]
        public int ProductID { get; set; }
        public string Image { get; set; }

        [StringLength(25)]
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
    }
}
