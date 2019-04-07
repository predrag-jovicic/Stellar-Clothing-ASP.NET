using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.Models
{
    public class Slider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Slider_id { get; set; }
        [Required]
        public bool Active { get; set; }
        [Required]
        [MaxLength(35)]
        public String Title { get; set; }
        [Required]
        [MaxLength(55)]
        public String Text { get; set; }

        public ICollection<SliderPhoto> SliderPhotos { get; set; }
    }
}
