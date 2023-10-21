using System;
using Domain.Models;

namespace Domain.Data
{
	public class AppDbContext
	{

		public Category[] Categories()
		{
			return new Category[]
			{
				new Category{Id = 1, Name = "Phone"},
				new Category{Id = 2, Name = "TV"},
				new Category{Id = 3, Name = "Console"},
				new Category{Id = 4, Name = "Computer"},
			};
		}

		public Product[] Products()
		{
			return new Product[]
			{
				new Product { Id = 1, Name = "Iphone 15", price = 3500, CreateDate = new DateTime(2023, 05, 15), CategoryName = Categories().FirstOrDefault(m=>m.Id == 1) },
				new Product { Id = 2, Name = "Iphone 14", price = 3000, CreateDate = new DateTime(2023, 05, 17), CategoryName = Categories().FirstOrDefault(m=>m.Id == 1) },
				new Product { Id = 3, Name = "Samsung TV", price = 2000, CreateDate = new DateTime(2023, 06, 15), CategoryName = Categories().FirstOrDefault(m=>m.Id == 2) },
				new Product { Id = 4, Name = "Sony PS5", price = 500, CreateDate = new DateTime(2023, 05, 11), CategoryName = Categories().FirstOrDefault(m=>m.Id == 3) },
			};
		}
	}
}

