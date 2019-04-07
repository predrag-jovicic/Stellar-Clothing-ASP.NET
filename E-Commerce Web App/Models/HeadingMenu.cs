using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.Models
{
    public class HeadingMenu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte HeadingItem_id { get; set; }
        [MaxLength(70)]
        [Required]
        public String Link { get; set; }
        [MaxLength(35)]
        [Required]
        public String Name { get; set; }
        public bool HasChildren { get; set; }
        [Required]
        public byte Parent { get; set; } 
        [Required]
        public byte Item_Column { get; set; }
    }
}
