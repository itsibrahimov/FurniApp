using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }

        [StringLength(10)]
        public string ConatactName { get; set; }

        [StringLength(13)]
        public string ConatactSurname { get; set; }

        [StringLength(50)]
        public string ConatactMail { get; set; }

        [StringLength(300)]
        public string Message { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(50)]
        public string MyMail { get; set; }

        [StringLength(300)]
        public string Phone { get; set; }
    }
}
