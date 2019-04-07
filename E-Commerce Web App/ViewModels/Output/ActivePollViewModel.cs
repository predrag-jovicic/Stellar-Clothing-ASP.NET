using E_Commerce_Web_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.ViewModels
{
    public class ActivePollViewModel
    {
        public short Poll_id { get; set; }
        public string Question { get; set; }
        public IEnumerable<Option> Options { get; set; }
    }
}
