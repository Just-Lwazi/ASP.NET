using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class GuardianDetailsMetaData
    {
        public int StudentId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Surname is required")]
        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is required")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Cellphone is required")]
        [Display(Name = "Cellphone Number")]
        [DataType(DataType.PhoneNumber)]
        [MinLength(10)]
        public int CellphoneNumber { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Address is required")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "City is required")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Postal Code")]
        [MaxLength(4)]
        public int PostalCode { get; set; }
    }
}