using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.ViewModels.Input
{
    public class RatingInput
    {
        public int ProductId { get; set; }
        [Range(1,5)]
        public byte Value { get; set; }
    }
}
