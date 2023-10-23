using Microsoft.AspNetCore.Mvc;
using DeGuzman_LabAct.Models;
using DeGuzman_LabAct.Services;
using DeGuzman_LabAct.Data;
using System;

namespace DeGuzman_LabAct.Controllers
{
    public class StudentController : Controller
    {
        /*List<Student> StudentList = new List<Student>
            {
                new Student()
                {
                    Id= 1,FirstName = "Gabriel",LastName = "Montano", Course = Course.BSIT, AdmissionDate = DateTime.Parse("2022-08-26"), GPA = 1.5, Email = "ghaby021@gmail.com"
                },
                new Student()
                {
                    Id= 2,FirstName = "Zyx",LastName = "Montano", Course = Course.BSIS, AdmissionDate = DateTime.Parse("2022-08-07"), GPA = 1, Email = "zyx@gmail.com"
                },
                new Student()
                {
                    Id= 3,FirstName = "Aerdriel",LastName = "Montano", Course = Course.BSCS, AdmissionDate = DateTime.Parse("2020-01-25"), GPA = 1.5, Email = "aerdriel@gmail.com"
                }
            };*/

        private readonly AppDbContext _dbContext;
        public StudentController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            
            return View(_dbContext.Roster);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = _dbContext.Roster.FirstOrDefault(st => st.Id == id);
            
            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {
            _dbContext.Roster.Add(newStudent);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult EditStudent()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EditStudent(int id) 
        {
            Student? Student = _dbContext.Roster.FirstOrDefault(st => st.Id == id);

            if (Student != null)
                return View(Student);

            return NotFound();
        }

        [HttpPost]
        public IActionResult EditStudent(Student studentStudent)
        { 
            var st = _dbContext.Roster.FirstOrDefault(st => st.Id == studentStudent.Id);

            if (st != null)
            { 
                st.Id = studentStudent.Id;
                st.FirstName = studentStudent.FirstName;
                st.LastName = studentStudent.LastName;
                st.GPA = studentStudent.GPA;
                st.Course = studentStudent.Course;
                st.AdmissionDate = studentStudent.AdmissionDate;
                st.Email = studentStudent.Email;
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        [HttpGet]
        public IActionResult DeleteStudent(int id)
        {
            Student? st = _dbContext.Roster.FirstOrDefault(st => st.Id == id);
            return View(st);
        }

        [HttpPost]
        public IActionResult DeleteStudent(Student insStudent)
        {
            var ins = _dbContext.Roster.FirstOrDefault(ins => ins.Id == insStudent.Id);

            if (ins != null)
            {
                _dbContext.Roster.Remove(ins);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}
