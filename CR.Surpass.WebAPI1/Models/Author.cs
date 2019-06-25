using System;
using System.ComponentModel.DataAnnotations;

namespace CR.Surpass.WebAPI1.Models
{
	public class Author : Base
	{
		public Author() : base()
		{
			this.ObjectTime = DateTime.Now;
		}

		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
	}
}