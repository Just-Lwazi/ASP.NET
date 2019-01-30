using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    [MetadataType(typeof(Student_InformationMetaData))]
    public partial class Student_Information
    {
        public string ConfirmPassword { get; set; }
        public bool RememberMe { get; set; }
    }
    public class Student_InformationMetaData
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Surname is required")]
        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Title is required")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Initials are required")]
        [Display(Name = "Initials")]
        public string Initials { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Gender is required")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Age is required")]
        [Display(Name = "Age")]
        public decimal Age { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Date of birth is required")]
        [Display(Name = "Date of birth")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]
        public System.DateTime DateOfBirth { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "ID number is required")]
        [MinLength(13)]
        [Display(Name = "ID number")]
        public decimal IDNumber { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Home Language is required")]
        [Display(Name = "Home language")]
        public string HomeLanguage { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "ID number is required")]
        [MinLength(13)]
        [Display(Name = "Passport")]
        public decimal PassportNumber { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Nationality is required")]
        [Display(Name = "Nationality")]
        public System.Data.Entity.Spatial.DbGeography Nationality { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Valid Email is required")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Minimum of 6 characters is required")]
        public string Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Confirm Password is required")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}