using Microsoft.AspNetCore.Mvc;
using buoi1.Models;
namespace buoi1.Controllers
{
    public class cnqt2Controller : Controller
    {
        public IActionResult Index()
        {
            //de trao doi du lieu tu action ve view co 2 cach 
            //c1: dung cac bo nho chia se nhu: view +bag, viewdata,appdata
            //c2: dung model 
            //vi su cach 1:
            ViewBag.Name = "Nguyen van a";
            ViewBag.Age = 22;
            ViewBag.Score = 4.5;
            //cach2:
            user u = new user(1000, "nmt", "aafasf");
            return View("abc",u);
        }
        public IActionResult MyAction() 
        { 
            return View(); 
        }

    }
}
