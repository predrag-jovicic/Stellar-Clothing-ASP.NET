using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.Models
{
    public class Vote
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Vote_id { get; set; }
        [Required]
        public String UserId { get; set; }
        public User User { get; set; }

        public DateTime Time { get; set; }

        public int Option_id { get; set; }
        public Option Option { get; set; }
    }
}
