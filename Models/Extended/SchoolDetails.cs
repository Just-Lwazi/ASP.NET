using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class SchoolDetailsMetaData
    {
        public int StudentId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "School name is required")]
        [Display(Name = "Name of High School")]
        public string NameOfSchool { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Highest grade passed is required")]
        [Display(Name = "Highest Grade passed")]
        [MaxLength(2)]
        public int HighestGradePassed { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Telphone Number is required")]
        [Display(Name = "Telnumber")]
        [DataType(DataType.PhoneNumber)]
        public int TelNumber { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Year in which senior certificate has been/will be obtained")]
        [Display(Name = "Year in which senior certificate has been/will be obtained")]
        public int SeniorCertificate { get; set; }

        [Display(Name ="Matric Exemption")]
        public string MatricExemption { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Address is required")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "City is required")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Postal code is required")]
        [Display(Name = "Postal Code")]
        [MaxLength(4)]
        public int PostalCode { get; set; }

        [Required]
        [Display(Name = "Active year")]
        [MaxLength(4)]
        public int ActiveYear { get; set; }

        [Required]
        [Display(Name = "Subject Name")]
        public string SubjectName { get; set; }

        [Required]
        [Display(Name = "Standard")]
        public string Standard { get; set; }

        [Required]
        [Display(Name = "Percentage")]
        public int Percentage { get; set; }
    }
}