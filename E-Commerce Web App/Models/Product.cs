using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Product_id { get; set; }
        [MaxLength(50)]
        [Required]
        public String Name { get; set; }
        [MaxLength(400)]
        [Required]
        public String Description { get; set; }

        public byte Category_id { get; set; }
        public byte Subcategory_id { get; set; }
        public short? Type_id { get; set; }

        public Category Category { get; set; }
        public Subcategory Subcategory { get; set; }
        public Type Type { get; set; }
        public ICollection<Rating> Ratings { get; set; }
        public ICollection<Price> Prices { get; set;}
        public ICollection<ProductVariant> ProductVariants { get; set; }
        public ICollection<ProductPhoto> ProductPhotos { get; set; }
    }
}
