using Microsoft.AspNetCore.Mvc;
using MyAppMVC.Models;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Reflection;
using System.Xml.Linq;

namespace MyAppMVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                    Id=1, Name="Hoang Anh",
                    Email="anh@gmail.com",
                    Phone="0123456789",
                    Address="Ha Noi",
                    Avatar = Url.Content("~/images/Avatar/01.jfif"),
                    Gender=1, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
                new Account()
                {
                    Id=2, Name="Truong Giang",
                    Email="giang@gmail.com",
                    Phone="0123654987",
                    Address="Ha Noi",
                    Avatar=Url.Content("~/images/Avatar/02.jfif"),
                    Gender=1, Bio="My name is small",
                    Birthday = new DateTime(1998, 7, 15)
                },
                new Account()
                {
                    Id=3, Name="Hoang Thuy",
                    Email="thuy@gmail.com",
                    Phone="0126518487",
                    Address="Ha Noi",
                    Avatar=Url.Content("~/images/Avatar/03.jfif"),
                    Gender=0, Bio="My name is small",
                    Birthday = new DateTime(1998, 7, 15)
                },
            };
            ViewBag.Accounts = accounts;
            return View();
        }
        [Route("Ho-so-cua-toi", Name = "profile")]
        public IActionResult Profile(int id)
        {
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                    Id =1,
                    Name="Hoang Anh",
                    Email = "anh@ggmail.com",
                    Phone="0123456789",
                    Address="Ha Noi",
                    Avatar = Url.Content("~/images/Avatar/01.jfif"),
                    Gender = 1,
                    Bio= "My name is small",
                    Birthday = new DateTime(1998, 7, 15)
                },
                new Account()
                {
                    Id = 2,
                    Name = "Truong Giang",
                    Email = "giang@gmail.com",
                    Phone = "0123654987",
                    Address = "Ha Noi",
                    Avatar = Url.Content("~/images/Avatar/02.jfif"),
                    Gender = 1,
                    Bio = "My name is small",
                    Birthday = new DateTime(1998, 7, 15)
                },
                new Account()
                {
                    Id = 3,
                    Name = "Hoang Thuy",
                    Email = "thuy@gmail.com",
                    Phone = "0126518487",
                    Address = "Ha Noi",
                    Avatar = Url.Content("~/images/Avatar/03.jfif"),
                    Gender = 0,
                    Bio = "My name is small",
                    Birthday = new DateTime(1998, 7, 15)
                }
            };
            //Su dung using =.Linq; truy xuat mot doi tuong trong danh sach theo id
            Account account = accounts.FirstOrDefault(ac => ac.Id == id);
            ViewBag.Account = account;
            return View();
        }
    }
}
