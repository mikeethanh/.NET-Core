using Microsoft.AspNetCore.Mvc;
using buoi1.Models;
namespace buoi1.Controllers
{
    public class cnqt2Controller : Controller
    {
        public IActionResult Index(string n, int a)
        {
            //de trao doi du lieu tu action ve view co 2 cach 
            //c1: dung cac bo nho chia se nhu: view +bag, viewdata,appdata
            //c2: dung model 
            //vi su cach 1:
            ViewBag.Name = n;
            ViewBag.Age = a;
            ViewBag.Score = 4.5;
            //cach2:
            user u = new user(1000, "nmt", "aafasf");
            return View("abc",u);
        }
        public IActionResult MyAction() 
        { 
            return View(); 
        }

        public IActionResult GetUser()
        {
            return View("PostUser");
        }
        [HttpPost]
        public IActionResult GetUser(user u)
        {
            return View("abc",u);
        }

    }
}
