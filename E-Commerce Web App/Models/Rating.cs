using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.Models
{
    public class Rating
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Rating_id { get; set; }
        [Required]
        public int Product_id { get; set; }
        [Required]
        public String UserId { get; set; }
        [Required]
        public int Value { get; set; }

        public Product Product { get; set; }
        public User User { get; set; }
    }
}
