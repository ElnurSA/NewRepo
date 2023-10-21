using System;
namespace Domain.Models
{
	public class Product : BaseEntity
	{
		public string Name { get; set; }
		public decimal price { get; set; }
		public DateTime CreateDate { get; set; }
		public Category CategoryName { get; set; }
	}
}

