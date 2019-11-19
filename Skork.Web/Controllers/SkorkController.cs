using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Skork.Web.Views.Skork;

namespace Skork.Web.Controllers
{
    public class SkorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}