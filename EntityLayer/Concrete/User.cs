using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class User
    {
        [Key]
        
        public int UserID { get; set; }

        [StringLength(12)]
        public string Name { get; set; }

        [StringLength(10)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Mail { get; set; }

        [StringLength(50)]
        public string Password { get; set; }
    }
}
