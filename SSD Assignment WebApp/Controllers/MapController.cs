using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SSD_Assignment_WebApp.Models;
using System.IO;

namespace SSD_Assignment_WebApp.Controllers
{
    public class MapController : Controller
    {
        static List<List<GridSpace>> map = new List<List<GridSpace>>();

        public IActionResult Index()
        {
            return View();
        }
    }
}
