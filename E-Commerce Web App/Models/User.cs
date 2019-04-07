using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.Models
{
    public class User : IdentityUser
    {
        [MaxLength(25)]
        [Required]
        public String FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        public String LastName { get; set; }
        [DataType(DataType.CreditCard)]
        [ProtectedPersonalData]
        public String CardNumber { get; set; }
        [ProtectedPersonalData]
        public short? CSC { get; set; }
        [MaxLength(70)]
        public String HomeAddress { get; set; }
        [DataType(DataType.PostalCode)]
        public int? ZipCode { get; set; }
        [MaxLength(50)]
        public String Country { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
