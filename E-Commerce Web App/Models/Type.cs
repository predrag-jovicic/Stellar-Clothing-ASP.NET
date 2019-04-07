using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.Models
{
    public class Type
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short Type_id { get; set; }
        [MaxLength(55)]
        [Required]
        public String Name { get; set; }

        ICollection<Product> Products { get; set; }
    }
}
