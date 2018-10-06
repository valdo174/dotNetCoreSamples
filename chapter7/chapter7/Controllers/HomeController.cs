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
		public IRepository repository = SimpleRepository.SharedRepository;

        public IActionResult Index()
		{
			return View(repository.Products.Where(p => p?.Price >= 0));
		}

		[HttpGet]
		public IActionResult AddProduct() => View(new Product());

		[HttpPost]
		public IActionResult AddProduct(Product p)
		{
			if (!ModelState.IsValid)
				return View();

			repository.AddProduct(p);

			return RedirectToAction("Index");
		}
    }
}