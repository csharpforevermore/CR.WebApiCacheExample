using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CR.Surpass.WebAPI1.Models
{
	public abstract class Base
	{
		public Base()
		{
			ObjectTime = DateTime.Now;
		}

		[NotMapped]
		public DateTime ObjectTime { get; set; }
	}
}