using System;
using Service.Services;
using Service.Services.Interfaces;

namespace Practice.Controllers
{
	public class ProductsController
	{
		private readonly IProductService _productService;

		public ProductsController()
		{
			_productService = new ProductService();
		}


		public void GetCount()
		{
			int count = _productService.GetCount();

			Console.WriteLine(count);
		}

		public void SearchByName()
		{
			Console.WriteLine("Add product search text: ");
			string searchText = Console.ReadLine();

			string resSearchText = searchText.Substring(0, 4);
			var result = _productService.Search(searchText);

			foreach (var item in result)
			{
				string data = $"Id: {item.Id}, Name: {item.Name}, Price: {item.price}, Category: {item.CategoryName}";
				Console.WriteLine(data);
			}
		}

		public void GetAll()
		{
            var result = _productService.GetAll();

            foreach (var item in result)
            {
                string data = $"Id: {item.Id}, Name: {item.Name}, Price: {item.price}, Category: {item.CategoryName}";
                Console.WriteLine(data);
            }
        }

		public void GetAvaragePrice()
		{
			var avgPrice = _productService.GetAvaragePrice();
			Console.WriteLine(avgPrice);

		}
		public void OrderByDate()
		{
			var result = _productService.OrderByDate();

            

            foreach (var item in result)
            {
                string data = $"Id: {item.Id}, Name: {item.Name}, Price: {item.price}, Date: {item.CreateDate:dd-MM-yyyy} Category: {item.CategoryName}";
                Console.WriteLine(data);
            }
        }
		public void GetAllByCategoryName()
		{
            Console.WriteLine("Add product category name: ");
            string category = Console.ReadLine();

            var result = _productService.GetAllByCategoryName(category);



            foreach (var item in result)
            {
                string data = $"Id: {item.Id}, Name: {item.Name}, Price: {item.price}, Date: {item.CreateDate:dd-MM-yyyy} Category: {item.CategoryName}";
                Console.WriteLine(data);
            }
        }

		public void GetAllByCategoryID()
		{
			Console.WriteLine("Add product category id");
			int categoryId = int.Parse(Console.ReadLine());

			var result = _productService.GetAllByCategoryID(categoryId);

			foreach (var item in result)
			{
				string data = $"Name: {item.Name}, Price: {item.price}, Date: {item.CreateDate: dd-MM-yyyy}";
				Console.WriteLine(data);
  
			}
			

		
		}
	}
}

