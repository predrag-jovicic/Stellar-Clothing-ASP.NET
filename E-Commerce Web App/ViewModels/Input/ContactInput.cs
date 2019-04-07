using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.ViewModels.Input
{
    public class ContactInput
    {
        [RegularExpression("^[A-Z][a-z]{2,15}(\\s[A-Z][a-z]{2,22})+$")]
        public string Tbname { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Tbemail { get; set; }
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}
