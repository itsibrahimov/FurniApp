﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }

        [StringLength(20)]
        public string Name { get; set; }
        public string Mail { get; set; }

        [StringLength(20)]
        public string Password { get; set; }
    }
}
