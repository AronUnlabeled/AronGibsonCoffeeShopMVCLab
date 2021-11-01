using AronGibsonCoffeeShopMVCLab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AronGibsonCoffeeShopMVCLab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        // returns veiw of page 
        public IActionResult Reg() {
            return View();
        }

        //does same as below but uses model object.
        public IActionResult Results(User u)
        {

            return View(u);
        }




        //returns view of page and gets parameters from reg to be used in results.
        //public IActionResult Results(string First,string Last,string Email,string Password)
        //{

        //    ViewData["First"] = First;
        //    ViewData["Last"] = Last;
        //    ViewData["email"] = Email;

        //    return View();
        //}


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
