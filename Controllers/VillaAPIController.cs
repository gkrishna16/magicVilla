using System;
using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/VillaApi")]
	[ApiController]
	public class VillaAPIController : ControllerBase
	{
		[HttpGet]
		public ActionResult<IEnumerable<VillaDTO>> GetVillas()
		{
			
			return Ok(VillaStore.villaList);
		}

		[HttpGet("{id:int}")]
		public ActionResult<VillaDTO> GetVillaById(int id)
		{
            if (id == 0)
            {
				return BadRequest();
            }
            var villa =  VillaStore.villaList.FirstOrDefault(u => u.Id == id);
			if (villa == null)
			{
				return NotFound();
			}
			return Ok(villa);
		}
		[HttpGet("name")]
		public ActionResult<VillaDTO> GetVillaByName(string name)
		{
			var villa = VillaStore.villaList.FirstOrDefault(u => u.Name == name);
			return Ok(villa);
		}
	}
}

