using Microsoft.AspNetCore.Mvc;
using DeGuzman_LabAct.Models;


namespace DeGuzman_LabAct.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>
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
            };
        public IActionResult Index()
        {

            return View(InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

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
            InstructorList.Add(newInstructor);
            return View("Index", InstructorList);
        }

        public IActionResult EditInstructor()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EditInstructor(int id)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(ins => ins.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult EditInstructor(Instructor insInstructor)
        {
            var ins = InstructorList.FirstOrDefault(ins => ins.Id == insInstructor.Id);

            if (ins != null)
            {
                ins.Id = insInstructor.Id;
                ins.FName = insInstructor.FName;
                ins.LName = insInstructor.LName;
                ins.IsTenured = insInstructor.IsTenured;
                ins.Rank = insInstructor.Rank;
                return View("Index", InstructorList);
            }
            return NotFound();
        }
    }
}
