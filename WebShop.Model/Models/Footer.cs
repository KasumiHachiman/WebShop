using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]//thuoc tinh khoa
        [MaxLength(250)]
        public string ID { set; get; }

        [Required]//ko rong
        public string Content { set; get; }
    }
}
