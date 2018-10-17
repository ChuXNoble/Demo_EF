using Demo_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_EF.ViewModels
{
    public class StudentFormViewModel
    {
        public Student Student { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}