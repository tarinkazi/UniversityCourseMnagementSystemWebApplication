using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UniversityCourseMnagementSystemWebApplication.Models
{
    public class UniversityDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        //public DbSet<StudentResultInformation> StudentResultInformations { get; set; }
        public DbSet<Semester> Semesters { get; set; }

        public DbSet<Designation> Designations { get; set; }
        //public DbSet<Room> Rooms { get; set; }
        //public DbSet<EnrollCourse> EnrollCourses { get; set; }
        //public DbSet<AssignCoursesOfTeacher> AssignCoursesOfTeachers { get; set; }
        public DbSet<AllocateClassRoom> AllocateClassRooms { get; set; }

        public System.Data.Entity.DbSet<UniversityCourseMnagementSystemWebApplication.Models.Room> Rooms { get; set; }


    }
}