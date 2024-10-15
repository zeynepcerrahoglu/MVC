using BtkAkademi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BtkAkademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index(){
            return View();
        }
        public IActionResult Apply(){ // bu get methodu
            return View();
        }
        [HttpPost] //browser form yardımıyla post yapacak
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm]Candidate model){
            return View();
        }
    }
}