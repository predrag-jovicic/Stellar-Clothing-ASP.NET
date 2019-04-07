using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.Models
{
    public class SliderPhoto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Photo_id { get; set; }
        [Required]
        [DataType(DataType.ImageUrl)]
        public String Source { get; set; }
        [Required]
        public String Alt { get; set; }
        public int Slider_id { get; set; }

        public Slider Slider { get; set; }
    }
}
