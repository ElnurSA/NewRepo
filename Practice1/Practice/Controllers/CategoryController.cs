using System;
using Service.Services;
using Service.Services.Interfaces;

namespace Practice.Controllers
{
	public class CategoryController
	{
        private readonly ICategoryService _categoryService;

        public CategoryController()
        {
            _categoryService = new CategoryService();
        }
        public void GetAll()
        {
            var categories = _categoryService.GetAll();

            foreach (var item in categories)
            {
                string data = $"Id: {item.Id}, Name: {item.Name}";
                Console.WriteLine(data);
            }
        }

    }
    
}

