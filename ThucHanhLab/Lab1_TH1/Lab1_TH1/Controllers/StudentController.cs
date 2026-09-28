using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Lab1_TH1.Models;

namespace Lab1_TH1.Controllers
{
    public class StudentController : Controller
    {
        private List<Student> listStudents = new List<Student>();
        public StudentController()
        {
            listStudents = new List<Student>()
            {
                new Student() {Id = 101, Name = "Hải Nam", Branch = Branch.IT,
                    Gender = Gender.Male, IsRegular = true,
                    Address = "A1-2018", Email = "nam@gmail.com"},
                new Student() {Id = 102, Name = "Minh Tú", Branch = Branch.BE,
                    Gender = Gender.Female, IsRegular = true,
                    Address = "A1-2019", Email = "tu@gmail.com"},
                new Student() {Id = 103, Name = "Hoàng Phong", Branch = Branch.CE,
                    Gender = Gender.Male, IsRegular = false,
                    Address = "A1-2020", Email = "phong@gmail.com"},
                new Student() {Id = 104, Name = "Xuân Mai", Branch = Branch.EE,
                    Gender = Gender.Female, IsRegular = false,
                    Address = "A1-2021", Email = "mai@gmail.com"},
            };
        }
        public IActionResult Index()
        {
            return View(listStudents);
        }
    }
}
