using Microsoft.AspNetCore.Mvc;

namespace FirstAPP_BackEnd.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int id)
        {
            ViewBag.Product = "Milk";
            ViewData["Count"] = 5;
            TempData["Quality"] = "Medium";
            return RedirectToAction("About");
           return View();
            
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult FAQ(string name,string surname)
        {
            string fullname = $"{name} {surname}";
            return Content(fullname);
        }
    }
}
