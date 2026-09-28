using Demo_Lesson07.Models.DataModels;
using Demo_Lesson07.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace Demo_Lesson07.Controllers
{
    public class MembersController : Controller
    {
        public static readonly List<Member> members = new List<Member>();
        public IActionResult Index()
        {
            return View(members);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Create(RegisterViewModels register)
        {
            if (ModelState.IsValid)
            {
                Member m = new Member
                {
                    MemberId = Guid.NewGuid().ToString(),
                    UserName = register.UserName,
                    FullName = register.FullName,
                    Email = register.Email,
                    Password = register.Password,
                    Phone = register.Phone,
                    BirthDay = register.BirthDay,
                };
                members.Add(m);
                return RedirectToAction("index");
            }
            else
            {
                return View(register);
            }
        }
    }
}
