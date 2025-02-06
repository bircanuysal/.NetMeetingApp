using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    //localhost/home
    public class HomeController : Controller
    {
        public IActionResult Index(){

            int time = DateTime.Now.Hour;

            var timeController = time > 12 ? "İyi Günler":"Günaydin";
            //ViewBag.UserName = "Bircan";

            ViewData["sayHi"] = timeController;
            ViewData["UserName"] = "Bircan";

            var meetingInfo = new MeetingInfo(){
                Id=1,
                Location="Ankara , ATO",
                Date = new DateTime(2025,02,01,20,0,0),
            };
            return View(meetingInfo);
        }
    }
}