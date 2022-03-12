using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityCourseMnagementSystemWebApplication.Models
{
    public class EnrollCourse
    {
        public int Id { get; set; }
        public int SudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime Date { get; set; }
    }
}