using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityCourseMnagementSystemWebApplication.Models
{
    public class StudentResultInformation
    {
        public int Id { get; set; }
        public int SudentId { get; set; }
        public int CourseId { get; set; }
        public string Grade { get; set; }
    }
}