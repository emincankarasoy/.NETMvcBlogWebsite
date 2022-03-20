using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int AboutID { get; set; }
        [StringLength(500)]
        public string AboutContent { get; set; }
        [StringLength(500)]
        public string AboutFooterContent { get; set; }
        [StringLength(100)]
        public string AboutImage { get; set; }  
        [StringLength(100)]
        public string AboutFooterImage { get; set; }    


    }
}
