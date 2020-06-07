using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using poblishingTest.Models;
using Domain.Repositories;
using Domain.Entities;

namespace poblishingTest.Controllers
{
    public class HomeController : Controller
    {
        private Context context;

        public HomeController(Context context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.TestTable);
        }

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
