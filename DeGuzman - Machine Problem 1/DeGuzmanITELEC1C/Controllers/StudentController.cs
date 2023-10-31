using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DeGuzmanITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddStudent() 
        {
            return View();
        }
    }
}
