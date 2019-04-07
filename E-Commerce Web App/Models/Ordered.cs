using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.Models
{
    public class Ordered
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Ordered_id { get; set; }
        public long ProductVariant_Id { get; set; }
        public int Order_Id { get; set; }
        public int Amount { get; set; }

        public ProductVariant ProductVariant { get; set; }
        public Order Order { get; set; }
    }
}
