using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab_18_Coffee_Shop_Part_1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab_18_Coffee_Shop_Part_1.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(RegisterUser user)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine(user.Email);
                return View(user);

            }
            return View(new RegisterUser());
        }
    }
}
