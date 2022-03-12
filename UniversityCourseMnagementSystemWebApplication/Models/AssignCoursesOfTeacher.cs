using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityCourseMnagementSystemWebApplication.Models
{
    public class AssignCoursesOfTeacher
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int CourseId { get; set; }
        public int TeacherId { get; set; }
        public string CreditTaken { get; set; }
        public string RemainCredit{ get; set; }
    }
}