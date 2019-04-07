using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.ViewModels.Input
{
    public class RegisterViewModel
    {
        [Required]
        [RegularExpression("^[A-Z][a-z]{2,15}$")]
        public string FirstName { get; set; }
        [RegularExpression("^[A-Z][a-z]{3,20}$")]
        [Required]
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }
        [RegularExpression("^[A-Z][A-Za-z0-9\\s\\-\\/]{5,45}$")]
        [Required]
        public string HomeAddress { get; set; }
        [DataType(DataType.PostalCode)]
        [Required]
        public int Zip { get; set; }
        [Required]
        [RegularExpression("^[A-Za-z]{2}$")]
        public string Country { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Required]
        public string PhoneNumber { get; set; }
        [Range(1,31)]
        [Required]
        public int Day { get; set; }
        [Range(1,12)]
        [Required]
        public int Month { get; set; }
        [Range(1936,2000)]
        [Required]
        public int Year { get; set; }
        //[DataType(DataType.CreditCard)]
        [Required]
        public string PaymentCard { get; set; }
        [Required]
        [RegularExpression("^[0-9]{3,5}$")]
        public short CSC { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
