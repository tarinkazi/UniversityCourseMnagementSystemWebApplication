using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityCourseMnagementSystemWebApplication.Models
{
    public class Course
    {
        public int Id { get; set; }

        [DisplayName("Name")]

        public string Name { get; set; }

        [DisplayName("Code")]

        public string Code { get; set; }
        public float credit { get; set; }

        public int DepartmentId { get; set; }

        public int SemesterId { get; set; }

        public int IsActive { get; set; }

        public  Department Department { get; set; }
        public Semester Semester { get; set; }
    }
}