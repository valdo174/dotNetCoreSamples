using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using chapter7.Models;

namespace chapter7.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
		{
			return View(SimpleRepository.SharedRepository.Products);
		}
    }
}