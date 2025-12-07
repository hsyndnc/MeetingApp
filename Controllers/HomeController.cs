using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
	public class HomeController : Controller
	{
		//Aksi belirtilmediği sürece bunlar GET requestidir.
		public IActionResult Index()
		{
			int saat = DateTime.Now.Hour;
			ViewBag.selamlama =saat >12 ?  "İyi Günler": "Günaydın";
			ViewBag.UserName = "Hüseyin";

			//ViewData["Selamlama"] =saat >12 ?  "İyi Günler": "Günaydın";   
			//ViewData["UserName"]="Hüseyin"
			//Viewdata yöntemiyle de bu verileri taşıyabiliri

			MeetingInfo meetingInfo = new MeetingInfo()
			{
				Id = 1,
				Location = "İstanbul",
				Date=new DateTime(2024 , 01 ,20,20,0,0),
				NumberOfPeople = 100,
			};

			return View(meetingInfo);
		}
	}
}
