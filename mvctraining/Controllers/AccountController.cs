 
using Microsoft.AspNetCore.Mvc;
using mvctraining.Models;

namespace mvctraining.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Login(string Email,String Password)
        //{
        //    return View();
        //}

        public IActionResult UserLogin(LoginViewModel model)
        {
           String em = model.Email;
            String us = model.Username;
            String pass = model.Password;
            ModelState.Clear();
            return View("Login");
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            return View();
        }

        public int Add(int x, int y)
        {
            return x + y;

        }
        public IActionResult SignUP ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUP(UserViewModel model)
        {

            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }


            return View();
        }
    }
}
