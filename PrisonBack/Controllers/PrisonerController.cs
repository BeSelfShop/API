﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PrisonBack.Domain.Models;
using PrisonBack.Domain.Services;
using PrisonBack.Resources.DTOs;
using PrisonBack.Resources.ViewModels;
using PrisonBack.Auth;

namespace PrisonBack.Controllers
{
	[Route("/api/[controller]")]
	
	public class PrisonerController : Controller
	{
		private readonly IPrisonerService _prisonerService;
		private readonly IMapper _mapper;
		private string controller = "Więźniowie";
		private readonly ILoggerService _loggerService;

		public PrisonerController(IPrisonerService prisonerService, IMapper mapper, ILoggerService loggerService)
		{
			_prisonerService = prisonerService;
			_mapper = mapper;
			_loggerService = loggerService;
		}

		[HttpGet("{id}")]
		[Authorize]
		public ActionResult<PrisonerVM> SelectedPrisoner(int id)
		{
			var prisoner = _prisonerService.SelectedPrisoner(id);
			return Ok(_mapper.Map<PrisonerVM>(prisoner));
		}
		
		[HttpGet]
		[Authorize]
		public async Task<IEnumerable<Prisoner>> AllPrisoner()
		{
			string userName = User.Identity.Name;
			var prisoner = await _prisonerService.AllPrisoner(userName);
			return prisoner;
		}
		[HttpPost]
		[Authorize(Roles = UserRoles.Admin)]
		public ActionResult<PrisonerVM> AddPrisoner([FromBody] PrisonerDTO prisonerDTO)
		{
			string userName = User.Identity.Name;
			var prisonerModel = _mapper.Map<Prisoner>(prisonerDTO);
			_prisonerService.CreatePrisoner(prisonerModel);
			_prisonerService.SaveChanges();
			_loggerService.AddLog(controller, "Dodano więźnia", userName);

			return Ok(StatusCode(200));
		}
	
		[HttpDelete("{id}")]
		[Authorize(Roles = UserRoles.Admin)]
		public ActionResult DeletePrisoner(int id)
		{
			string userName = User.Identity.Name;

			var prisoner = _prisonerService.SelectedPrisoner(id);
			if (prisoner == null)
			{
				return NotFound();
			}
			_prisonerService.DeletePrisoner(prisoner);
			_prisonerService.SaveChanges();
			_loggerService.AddLog(controller, "Usunięto więźnia", userName);


			return Ok(StatusCode(200));
		}
	
		[HttpPut("{id}")]
		[Authorize(Roles = UserRoles.Admin)]
		public ActionResult UpdatePrisoner(int id, [FromBody] PrisonerDTO prisonerDTO)
		{
			string userName = User.Identity.Name;

			var prisoner = _prisonerService.SelectedPrisoner(id);
			if (prisoner == null)
			{
				return NotFound();
			}
			_mapper.Map(prisonerDTO, prisoner);
			_prisonerService.UpdatePrisoner(prisoner);
			_prisonerService.SaveChanges();
			_loggerService.AddLog(controller, "Edytowano dane więźnia", userName);


			return Ok(StatusCode(200));
		}

	}
}
