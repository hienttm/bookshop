using System;
using Microsoft.AspNetCore.Mvc;

namespace BookShopMvc.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class HomeController : Controller
	{
		public HomeController()
		{
		}
		public IActionResult Index()
		{
			return View();
		}
	}
}
