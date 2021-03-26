using Microsoft.AspNetCore.Mvc;
using PrisonBack.Domain.Models;
using PrisonBack.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisonBack.Controllers
{
    [Route("/api/[controller]")]
    public class ReasonController : Controller
    {
		private readonly IReasonService _reasonService;
        public ReasonController(IReasonService reasonService)
        {
            _reasonService = reasonService;
        }

		[HttpGet]
		public async Task<IEnumerable<Reason>> AllReason()
		{
			var reason = _reasonService.AllReasons();
			return await reason;
		}
    }
}
