using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Model.Models
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        [Key]// thuoc tinh la khoa chinh
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]// create int autoindentity
        public int ID { set; get; }

        [Required] // thuoc tinh ko dc null
        [MaxLength(256)]
        public string Name { set; get; }

        public virtual IEnumerable<Menu> Menus { set; get; }//tao list o bang cha de tro den bang con
    }
}
