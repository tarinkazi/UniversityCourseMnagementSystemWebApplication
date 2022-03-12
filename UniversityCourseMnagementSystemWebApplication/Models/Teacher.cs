using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversityCourseMnagementSystemWebApplication.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public string ContactNo { get; set; }
        [Column(TypeName = "int")]
        public int DesignationId { get; set; }
        public int DepartmentId { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public double CreditTaken { get; set; }

        public Designation Designation { get; set; }
        public Department Department { get; set; }
    }
}