using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PrisonBack.Domain.Models;
using PrisonBack.Domain.Services;

namespace PrisonBack.Controllers
{
	[Route("/api/[controller]")]
	[Authorize]
	public class CellTypeController : Controller
    {
		private readonly ICellTypeService _cellTypeService;

		public CellTypeController(ICellTypeService cellTypeService)
		{
			_cellTypeService = cellTypeService;

		}
		[HttpGet]
		public async Task<IEnumerable<CellType>> AllCellType()
		{
			var cellTypes = _cellTypeService.AllCellType();
			return await cellTypes;
		}
	}
}
