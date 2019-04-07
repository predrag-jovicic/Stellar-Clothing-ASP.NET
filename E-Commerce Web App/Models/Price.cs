using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.Models
{
    public class Price
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Price_id { get; set; }
        public double Net_price { get; set; }
        public double Discount { get; set; }
        [Required]
        public bool Active { get; set; }
        public int Product_id { get; set; }

        public Product Product { get; set; }
    }
}
