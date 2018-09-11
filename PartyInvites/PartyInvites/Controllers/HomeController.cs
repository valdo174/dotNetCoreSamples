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

		[HttpGet]
		public IActionResult RsvpForm()
		{
			return View();
		}

		[HttpPost]
		public ViewResult RsvpForm(GuestInfo info)
		{
			AnswersRepository.AddResponse(info);
			return View("Thanks");
		}

		[HttpGet]
		public IActionResult GuestList()
		{
			return View(AnswersRepository.Responses);
		}

    }
}
