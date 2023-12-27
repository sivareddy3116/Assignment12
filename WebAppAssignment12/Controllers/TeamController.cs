using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppAssignment12.Models;

namespace WebAppAssignment12.Controllers
{
    public class TeamController : Controller
    {
        // GET: Team
        static List<Team> _teams = new List<Team>();

        public ActionResult Index()
        {
            var teams = GetTeams();
            return View(teams);
        }

        private List<Team> GetTeams()
        {
            // Retrieve teams from your data source (e.g., database)
            // For simplicity, hardcoding teams here
            return new List<Team>
            {
                new Team { TeamId = 1, TeamName = "NOWC India" },
                new Team { TeamId = 2, TeamName = "Australia" },
                new Team { TeamId = 3, TeamName = "West Indies" },
                new Team { TeamId = 4, TeamName = "England" }
            };
        }
        public ActionResult Display() 
        {
            ViewBag.msg = "Pagr content";
            return View();
        }
    }
}
