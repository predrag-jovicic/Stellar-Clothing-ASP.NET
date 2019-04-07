using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.Models
{
    public class Poll
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short Poll_id { get; set; }
        [MaxLength(100)]
        [Required]
        public String Question { get; set; }
        [Required]
        public bool Active { get; set; }

        public ICollection<Option> Options { get; set; }
    }
}
