// https://docs.microsoft.com/en-us/aspnet/web-api/overview/testing-and-debugging/unit-testing-with-aspnet-web-api
using System;

namespace CR.Surpass.WebAPI1.Models
{
	public class Product
	{
		public Product()
		{
			CreatedDate = DateTime.Now;
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		public DateTime CreatedDate { get; set; }
	}
}