using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_EF.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Course_Name { get; set; }
        public int Semester { get; set; }
    }
}