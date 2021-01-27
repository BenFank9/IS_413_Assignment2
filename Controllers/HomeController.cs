using IS_413_Assignment2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IS_413_Assignment2.Controllers
{
    public class HomeController : Controller 
    {
        public IActionResult Index()
        {
            /*throw new IndexOutOfRangeException();*/

            return View(); /*this returns the index view*/
        }

        [HttpGet("Grades")]
        public IActionResult Grades()
        {
            return View();
        }

        [HttpPost("Grades")]
        public IActionResult Grades(GradesModel model)
        {
            //this is further validation that if a rule is broken, the person will have to enter different numbers for their grades.
            //if the inputs are valid, the grade will be shown and then the person will be redirected to the home page.
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View();


        }
    }
}
