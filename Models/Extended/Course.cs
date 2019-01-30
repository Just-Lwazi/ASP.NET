using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class CourseMetaData
    {
        public int StudentId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Field is required")]
        [Display(Name = "Program")]
        public string Program { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Alternative is required")]
        [Display(Name = "Alternative Program")]
        public string AlternativeProgram { get; set; }

        [Required]
        [Display(Name = "Field")]
        public string Field { get; set; }
    }
}