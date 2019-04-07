using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.Models
{
    public class ProductVariant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ProductVariant_Id { get; set; }
        public int Product_id { get; set; }
        public byte? Size_id { get; set; }
        public byte? Color_id { get; set; }
        public int Quantity { get; set; }

        public Product Product { get; set; }
        public Size Size { get; set; }
        public Color Color { get; set; }
    }
}
