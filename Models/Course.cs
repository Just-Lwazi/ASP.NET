//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace School.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public string Program { get; set; }
        public string AlternativeProgram { get; set; }
        public int FieldId { get; set; }
        public string Field { get; set; }
    }
}
