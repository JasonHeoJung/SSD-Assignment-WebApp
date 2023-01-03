using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SSD_Assignment_WebApp.Models;
using System.IO;

namespace SSD_Assignment_WebApp.Controllers
{
    public class GameController : Controller
    {
        
        // GET: GameController
        public ActionResult Index()
        {

            Game game = new Game();
            
            if (HttpContext.Session.GetString("GameType") == "NewGame")
            {
                for (int i = 0; i < 20; i++)
                {
                    List<GridSpace> row = new List<GridSpace>();
                    for (int j = 0; j < 20; j++)
                    {
                        GridSpace g = new GridSpace { ycoord = i, xcoord = j, Building = 'N', Empty = true };
                        row.Add(g);
                    }
                    game.Map.Add(row);
                }
                game.TurnNo = 0;
                game.CoinBal = 16;
                game.Score = 0;
            }
            return View(game);
        }

        public ActionResult Game(Game g)
        {
            return View(g);
        }

        // GET: GameController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GameController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GameController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GameController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GameController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GameController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GameController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
