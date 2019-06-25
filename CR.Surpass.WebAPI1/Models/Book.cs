using System;
using System.ComponentModel.DataAnnotations;

namespace CR.Surpass.WebAPI1.Models
{
	public class Book : Base
	{
		public Book() : base()
		{
			this.ObjectTime = DateTime.Now;
		}

		[Key]
		public int Id { get; set; }
		[Required]
		public string Title { get; set; }
		public int Year { get; set; }
		public decimal Price { get; set; }
		public string Genre { get; set; }

		// Foreign Key
		public int AuthorId { get; set; }
		// Navigation property
		public Author Author { get; set; }


	}
}