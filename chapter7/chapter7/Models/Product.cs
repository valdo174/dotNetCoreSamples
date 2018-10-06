using System.ComponentModel.DataAnnotations;

namespace chapter7.Models
{
	public class Product
	{
		[Required(ErrorMessage = "You shold enter a Name!")]
		public string Name { get; set; }

		[Required(ErrorMessage = "You shold enter a Price!")]
		public decimal Price { get; set; }

		public Product()
		{
			
			
		}
	}
}