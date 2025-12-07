using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;

namespace MeetingApp.Controllers
{
	public class MeetingController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Apply()
		{
			return View();	
		}

		[HttpPost]
		public IActionResult Apply(UserInfo model)
		{
			// form içindeki name tagleri ile birebir eşleştirilir buradaki değişkenler.
			return View();
		}
		public IActionResult List()
		{
			return View();
		}
	}
}
