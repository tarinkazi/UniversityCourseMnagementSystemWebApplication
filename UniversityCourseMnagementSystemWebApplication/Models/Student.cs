using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityCourseMnagementSystemWebApplication.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string RegNo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string AddedDate { get; set; }
        public int DepartmentId { get; set; }

        public Department Department { get; set; }

       

        
    }
}