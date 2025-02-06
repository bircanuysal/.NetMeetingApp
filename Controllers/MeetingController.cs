using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;
using System.Diagnostics;
namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        [HttpGet]
        public IActionResult Apply(){
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo model){
           Repository.CreateUser(model);
           ViewBag.UserCount = Repository.Users.Where(i=>i.WillAttend ==true).Count(); 
           return View("Thanks",model);
        }

        [HttpGet]
        public IActionResult List(){
            return View();
        }

        
    }
}