using System;
using MagicVilla_VillaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
	[Route("api/products")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		public ProductController()
		{
		}

		public IEnumerable<Products> GetProducts ()
		{
			return new List<Products> { new Products { Id = 1, Name ="Node API", Price=300 } ,
			new Products {Id = 2, Name = "Dotnet API", Price = 400}
		};
		}

	}
}

