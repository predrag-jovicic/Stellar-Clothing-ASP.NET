using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Order_id { get; set; }
        public DateTime Time { get; set; }
        [Required]
        public String UserId { get; set; }
        public User User { get; set; }

        public ICollection<Ordered> Ordered { get; set; }
    }
}
