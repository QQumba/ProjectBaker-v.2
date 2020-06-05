using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectBaker.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace ProjectBaker.Web.Controllers
{
	[Authorize]
	public class ProjectHomeController : Controller
	{
		public IActionResult Follow()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(ProjectViewModel model)
		{
			if (ModelState.IsValid)
			{

			}

			return View();
		}

		public IActionResult Manage()
		{
			return Content("manage");
		}
	
		[HttpGet]
		public IActionResult Update()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Update(ProjectViewModel model)
		{
			return View();
		}

		public IActionResult Proj()
		{
			ViewBag.ProjectName = "Test project";
			return View();
		}
	}
}
