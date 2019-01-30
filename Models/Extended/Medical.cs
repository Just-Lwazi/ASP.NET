using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class Medical
    {
        public int StudentId { get; set; }
        public string Accomodation { get; set; }
        public string BadEyesight { get; set; }
        public string CerebralPalsy { get; set; }
        public string Deafness { get; set; }
        public string SpeechDefect { get; set; }

        [Display(Name = "Other")]
        public string Other { get; set; }
        public string Wheelchair { get; set; }
    }
}