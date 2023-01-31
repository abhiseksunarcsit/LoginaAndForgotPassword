using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using DAL.Context;

namespace StaffWeb.Controllers
{
    public class loginController : Controller
    {
        private IUserService UService;
        public loginController(IUserService uService)
        {
            UService = uService;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult login()
        {
            //UService.ValidateUser()
            return View();
        }
        [HttpPost]
        public IActionResult Login(Model.login model)
        {
            if (ModelState.IsValid)
            {
                bool valid = UService.ValidateUser(model.Username, model.Password);
                if (valid)
                {
                    TempData["message"] = "Wellcome";
                    // return View("/Views/Home/Index");
                    return RedirectToAction("Index", "Home", TempData["message"]);

                }
                else
                {
                    TempData["message"] = "Username or Password is wrong.!";
                    // return View("/Views/Home/Index");
                    return RedirectToAction("login", "login", TempData["message"]);

                }
            }
            return View(TempData["message"]);

        }

    }


}
