using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ContactID { get; set; }
        [StringLength(50)]
        public string ContactName { get; set; }
        [StringLength(50)]
        public string ContactSurname { get; set; }
        [StringLength(50)]
        public string ContactMail { get; set; }
        [StringLength(50)]
        public string ContactSubject { get; set; }
        public string ContactMessage { get; set; }
    }
}
