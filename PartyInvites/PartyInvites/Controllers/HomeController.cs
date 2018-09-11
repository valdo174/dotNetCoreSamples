using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
			int hour = DateTime.Now.Hour;
			ViewBag.Greetings = hour > 12 ? "Good Afternoon" : "Good Morning";

            return View();
        }

    }
}
