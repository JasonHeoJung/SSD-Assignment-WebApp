using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SSD_Assignment_WebApp.Controllers
{
    public class Instructions : Controller
    {
        // GET: Instructions
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BuildingRules()
        {
            return View();
        }
    }
}
