using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public partial class AfterSchoolMetaData
    {
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "Period From")]
        [MaxLength(4)]
        public int PeriodFrom { get; set; }

        [Required]
        [Display(Name = "Period To")]
        [MaxLength(4)]
        public int PeriodTo { get; set; }

        [Required]
        [Display(Name = "Name of University/Technicon/College")]
        public string NameOfInstituion { get; set; }

        [Required]
        [Display(Name = "Name of Qualification e.g Degree/Diploma/Certificate")]
        public string NameOfQualification { get; set; }

        [Required]
        [Display(Name = "Study Complete")]
        public bool StudyComplete { get; set; }

        [Required]
        [Display(Name = "Reference Number")]
        public string ReferenceNumber { get; set; }
    }
}