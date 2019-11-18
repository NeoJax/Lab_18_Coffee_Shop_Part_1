using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_18_Coffee_Shop_Part_1.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab_18_Coffee_Shop_Part_1.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly UserDbContext _context;

        public RegistrationController(UserDbContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult Summary(RegisterUser user)
        {
            User newUser = new User();
            newUser.UserName = user.UserName;
            newUser.Pass = user.Pass;
            newUser.Email = user.Email;
            newUser.Member = user.Member;
            newUser.Regular = user.Regular;

            if (ModelState.IsValid)
            {
                Console.WriteLine(newUser);
                _context.Users.Add(newUser);
                return View(user);
            }
            return View("Registration");
        }
    }
}
