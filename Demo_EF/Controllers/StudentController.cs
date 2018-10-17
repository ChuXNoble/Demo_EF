using Demo_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Demo_EF.ViewModels;

namespace Demo_EF.Controllers
{
    public class StudentController : Controller
    {
        private AptechDb _context;
        public StudentController()
        {
            _context = new AptechDb();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Student
        public ActionResult Index()
        {
            var students = _context.Students.Include(c => c.Course).ToList();
            return View(students);
        }
        //Demo/Student/id
        public ActionResult Details(int id)
        {
            var student = _context.Students.Include(c => c.Course).SingleOrDefault(c => c.Id == id);
            if (student == null)
                return HttpNotFound();

            return View(student);
        }
        public ActionResult New()
        {
            var courses = _context.Courses.ToList();
            var viewModel = new StudentFormViewModel()
            {                
                Courses = courses
            };
            return View("StudentForm",viewModel);
        }
        public ActionResult Save(Student student)
        {
            if(student.Id == 0)
            {
                _context.Students.Add(student);
            }
            else
            {
                var studentInDb = _context.Students.Single(s => s.Id == student.Id);
                studentInDb.Stud_Name = student.Stud_Name;
                studentInDb.Email = student.Email;
                studentInDb.CourseId = student.CourseId;
            }
            _context.SaveChanges();
            

            return RedirectToAction("Index","Student");
        }
        public ActionResult Edit(int id)
        {
            var student = _context.Students.SingleOrDefault(s => s.Id == id);

            if (student == null)
                return HttpNotFound();

            var viewModel = new StudentFormViewModel
            {
                Student = student,
                Courses = _context.Courses.ToList()
            };
            return View("StudentForm",viewModel);
        }
    }
}