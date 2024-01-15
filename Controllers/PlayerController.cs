using Assignments.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignments.Controllers
{
    public class PlayerController : Controller
    {
        static List<Player> players = new List<Player>()
        {
            new Player() {PId = 1, PName="Dhoni",PCountry="India",PType="All-Rounder"},
            new Player() {PId = 2, PName="Kohli",PCountry="India",PType="Batsman"},
            new Player() {PId = 3, PName="Rohit",PCountry="India",PType="Batsman"},
            new Player() {PId = 4, PName="Shubman",PCountry="India",PType="Batsman"},
            new Player() {PId = 5, PName="Sachin",PCountry="India",PType="Bowler"},

        };
        public IActionResult Index()
        {
            return View(players);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Player());
        }
        [HttpPost]
        public IActionResult Create(Player play)
        {
            if (ModelState.IsValid)
            {
                players.Add(play);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
