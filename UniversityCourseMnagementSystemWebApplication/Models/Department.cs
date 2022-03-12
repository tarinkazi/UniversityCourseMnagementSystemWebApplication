using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniversityCourseMnagementSystemWebApplication.Models
{
    public class Department
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide department name")]
        
        [DisplayName("Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please provide department code")]


        [DisplayName("Code")]
        [StringLength(7, MinimumLength = 2)]       
        public string Code { get; set; }
    }
}