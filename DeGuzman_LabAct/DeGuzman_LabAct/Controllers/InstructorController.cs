using Microsoft.AspNetCore.Mvc;
using DeGuzman_LabAct.Models;
using DeGuzman_LabAct.Services;
using System.ComponentModel.DataAnnotations;
using DeGuzman_LabAct.Data;

namespace DeGuzman_LabAct.Controllers
{
    public class InstructorController : Controller
    {
        /*List<Instructor> InstructorList = new List<Instructor>
            {
                new Instructor()
                {
                    Id= 1,
                    FName = "Jason",
                    LName = "Beltran", 
                    Rank = Rank.Instructor, 
                    HiringDate = DateTime.Parse("2022-08-26"), 
                    IsTenured = true
                },
                new Instructor()
                {
                    Id= 2,
                    FName = "Manuel",
                    LName = "Barce", 
                    Rank = Rank.AssistantProfessor, 
                    HiringDate = DateTime.Parse("2022-08-07"), 
                    IsTenured = true
                },
                new Instructor()
                {
                    Id= 3,
                    FName = "Mikhail",
                    LName = "De Guzman", 
                    Rank = Rank.AssociateProfessor, 
                    HiringDate = DateTime.Parse("2020-01-25"), 
                    IsTenured = false
                },
                new Instructor()
                {
                    Id= 4,
                    FName = "Marie",
                    LName = "Ronquillo", 
                    Rank = Rank.Professor, 
                    HiringDate = DateTime.Parse("2019-01-25"), 
                    IsTenured = true
                }
            };*/
        private readonly AppDbContext _dbcontext;
        public InstructorController(AppDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public IActionResult Index()
        {

            return View(_dbcontext.Instructors);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = _dbcontext.Instructors.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddInstructor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            if (!ModelState.IsValid)
                return View();
            _dbcontext.Instructors.Add(newInstructor);
            return RedirectToAction("Index");
        }

        public IActionResult EditInstructor()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EditInstructor(int id)
        {
            Instructor? instructor = _dbcontext.Instructors.FirstOrDefault(ins => ins.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult EditInstructor(Instructor insInstructor)
        {
            var ins = _dbcontext.Instructors.FirstOrDefault(ins => ins.Id == insInstructor.Id);

            if (ins != null)
            {
                ins.Id = insInstructor.Id;
                ins.FName = insInstructor.FName;
                ins.LName = insInstructor.LName;
                ins.IsTenured = insInstructor.IsTenured;
                ins.Rank = insInstructor.Rank;
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        [HttpGet]
        public IActionResult DeleteInstructor(int id)
        {
            Instructor? instructor = _dbcontext.Instructors.FirstOrDefault(instructor => instructor.Id == id);
            return View(instructor);
        }
        [HttpPost]
        public IActionResult DeleteInstructor(Instructor insInstructor)
        {
            var ins = _dbcontext.Instructors.FirstOrDefault(ins => ins.Id == insInstructor.Id);

            if (ins != null)
            {
                _dbcontext.Instructors.Remove(ins);
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}
