using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
	public static class MyExtensionMethods
	{
		public static IEnumerable<Product> Filter(this IEnumerable<Product> products, Func<Product, bool> selector)
		{
			foreach(Product product in products)
			{
				if (selector(product))
					yield return product;
			}
		}
	}
}
