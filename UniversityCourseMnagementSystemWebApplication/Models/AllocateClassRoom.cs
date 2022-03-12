using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityCourseMnagementSystemWebApplication.Models
{
    public class AllocateClassRoom
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int CourseId { get; set; }
        public int RoomId { get; set; }
        public string Day { get; set; }
        public DateTime Date { get; set; }
        public int IsActive { get; set; }

       // public Department Department { set; get; }
        public Course Course { set; get; }
        public Room Room { set; get; }
      
    }
}