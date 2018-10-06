using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using chapter7.Controllers;
using chapter7.Models;
using Microsoft.AspNetCore.Mvc;

namespace chapter7.tests
{
	public class HomeControllerTest
	{
		class ModelCompleteFakeRepository : IRepository
		{
			public IEnumerable<Product> Products { get; } = new Product[]
			{
				new Product(){Name = "P1", Price = 123M },
				new Product(){Name = "P2", Price = 152M },
				new Product(){Name = "P3", Price = 15.6M  },
				new Product(){Name = "P4", Price = 78.9M },
				new Product(){Name = "P5", Price = 85.5M },

			};

			public void AddProduct(Product p)
			{
				// nothing to do here
			}
		}

		[Fact]
		public void IndexActionModelComplete()
		{
			var controller = new HomeController();
			controller.repository = new ModelCompleteFakeRepository();

			var model = (controller.Index() as ViewResult)?.ViewData.Model as IEnumerable<Product>;

			Assert.Equal(controller.repository.Products, model,
				Comparer.Get<Product>((p1, p2) => p1.Name == p2.Name && p1.Price == p2.Price));
		}
	}
}
