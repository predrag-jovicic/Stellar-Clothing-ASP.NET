using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.Models
{
    public class Size
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Size_id { get; set; }
        [MaxLength(10)]
        [Required]
        public String Name { get; set; }

        public ICollection<ProductVariant> ProductVariants { get; set; }
    }
}
