using Microsoft.AspNetCore.Mvc;
using YourNamespace.Models;
using System.Collections.Generic;

namespace YourNamespace.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            // Sample data
            var teacher = new Teacher { Id = 1, Name = "Mr. Smith" };
            var course = new Course { Id = 1, CourseName = "Mathematics", Teacher = teacher };
            
            var students = new List<Student>
            {
                new Student { Id = 1, Name = "John Doe", Course = course },
                new Student { Id = 2, Name = "Jane Doe", Course = course }
            };

            return View(students);
        }
    }
}
