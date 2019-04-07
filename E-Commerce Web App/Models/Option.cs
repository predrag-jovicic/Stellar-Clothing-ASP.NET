using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.Models
{
    public class Option
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Option_id { get; set; }
        [MaxLength(60)]
        [Required]
        public String Name { get; set; }
        public short Poll_id { get; set; }

        public Poll Poll { get; set; }
        public ICollection<Vote> Votes { get; set; }
    }
}
