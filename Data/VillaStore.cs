﻿using System;
using MagicVilla_VillaAPI.Models;

namespace MagicVilla_VillaAPI.Data
{
	public class VillaStore
	{
        public static List<VillaDTO> villaList = new List<VillaDTO>
            {
                new VillaDTO {Id = 1, Name = "Pool View"},
                new VillaDTO {Id = 2, Name = "Beach View"},
                new VillaDTO{Id = 3, Name = "Beach View 3"}
    };
	}
}


