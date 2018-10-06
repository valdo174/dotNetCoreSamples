using System;
using Xunit;
using chapter7.Models;

namespace chapter7.tests
{
	public class ProductTest
	{
		[Fact]
		public void CanChangeProductName()
		{
			var p = new Product() { Name = "Test", Price = 100M };

			p.Name = "New Name";

			Assert.Equal("New Name", p.Name);
		}

		[Fact]
		public void CanChangeProductPrice()
		{
			var p = new Product() { Name = "Test", Price = 100M };

			p.Price = 120M;

			Assert.Equal(120M, p.Price);
		}
	}
}
