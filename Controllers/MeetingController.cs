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

			if (ModelState.IsValid)
			{
				Repository.CreateUser(model);
				ViewBag.UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();
				return View("Thanks", model);
				//Eğer validation sınıfı tetiklenmediyse bir hata yoktur true döner.
			}
			else
			{
				return View(model);
				//Hata varsa false döner ve burası çalışır.model içinde girilen hatalı bilgiler vardır.Bunlar tekrar gönderilir hata mesajları ile.
			}
            // form içindeki name tagleri ile birebir eşleştirilir buradaki değişkenler.

            
		}
		public IActionResult List()
		{
			return View(Repository.Users); //static olduğu için direkt listeye ulaşabiliyoruz
		}

		public IActionResult Details(int id)
		{
			return View(Repository.GetById(id));
		}
	}
}
