using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjectBaker.Domain.Entities;
using ProjectBaker.Services;
using ProjectBaker.Web.Models;

namespace ProjectBaker.Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly AppService _appService;
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger, AppService appService)
		{
			_logger = logger;
			_appService = appService;
		}

		public IActionResult Index()
		{
			//_db.Set<Project>().Add(new Project() { Name = "pr1"});
			_appService.AddProject(new Domain.Entities.Project() { Name = "pr1" });
			var proj = _appService.GetAllProjects();
			if(proj.Count != 0)
			{
				ViewBag.Proj = proj;
			}
			else
			{
				ViewBag.Proj = new List<Project>() { new Project() { Name = "empty" } };
			}

			return View();
		}

		[Authorize]
		public IActionResult Privacy()
		{
			ViewBag.Claims = User.Claims.ToList();
			//return View();
			return Content(User.Claims?.FirstOrDefault(u => u.Type == "role").Value);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
