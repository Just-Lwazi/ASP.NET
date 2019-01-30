using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Schools.Models
{
    public class BursaryMetaData
    {
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "Do you make use of a Bursary?")]
        public string Bursarys { get; set; }

    }
}