using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.Models
{
    public class Color
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Color_id { get; set; }
        [MaxLength(20)]
        [Required]
        public String Name { get; set; }

        public ICollection<ProductVariant> ProductVariants { get; set; }
    }
}
