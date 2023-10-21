using System;
using Domain.Models;

namespace Service.Services.Interfaces
{
	public interface ICategoryService
	{
		Category[] GetAll();
	}
}

