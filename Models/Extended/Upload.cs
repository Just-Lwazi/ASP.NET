using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace School.Models
{
    public class Upload
    {
        [Display(Name = "Upload ID")]
        [ValidateFile]
        [Required(ErrorMessage = "Please choose file to upload")]
        public HttpPostedFileBase IdentityDocument { get; set; }

        [Display(Name = "Upload Matric Certificate")]
        [ValidateFile]
        [Required(ErrorMessage = "Please choose file to upload")]
        public HttpPostedFileBase MatricCertificate { get; set; }

        [Display(Name = "Upload Qualification")]
        [ValidateFile]
        public HttpPostedFileBase Qualifiation { get; set; }
    }

    public class ValidateFileAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            int MaxContentLength = 1024 * 1024 * 3; //3MB
            string[] AllowedFileExtensions = new string[] { "jpg", "gif", "png", "pdf" };
            // Designing model with data annotation validation 

            var file = value as HttpPostedFileBase;

            if (file == null)
                return false;
            else if (!AllowedFileExtensions.Contains(file.FileName.Substring(file.FileName.LastIndexOf('.'))))
            {
                ErrorMessage = "Please upload your document of type: " + string.Join(", ", AllowedFileExtensions);
                return false;
            }
            else if (file.ContentLength > MaxContentLength)
            {
                ErrorMessage = "Your document is too large, maximum allowed size is: " + (MaxContentLength / 1024).ToString() + "MB";
                return false;
            }
            else
                return base.IsValid(value);
        }
    }
}
