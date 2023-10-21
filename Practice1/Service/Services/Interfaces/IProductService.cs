using System;
using Domain.Models;

namespace Service.Services.Interfaces
{
	public interface IProductService
	{
		int GetCount();
		Product[] Search(string searchText);
		Product[] GetAll();
		decimal GetAvaragePrice();
		Product[] OrderByDate();
		Product[] GetAllByCategoryName(string categoryName);
		Product[] GetAllByCategoryID(int id);
	}
}

