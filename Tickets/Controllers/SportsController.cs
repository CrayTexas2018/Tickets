using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tickets.Models;

namespace Tickets.Controllers
{
    public class SportsController : Controller
    {
        ApplicationDbContext db;
        // GET: Sports
        public ActionResult Info(string sport)
        {
            db = new ApplicationDbContext();
            try
            {
                // Check if sport is in database
                Sport s = db.Database.SqlQuery<Sport>("EXEC GetSportData @p0", sport).Single();

                // Get Content for that sport ID over the past month
                List<Content> c = db.Database.SqlQuery<Content>("EXEC GetContent @p0, @p1, @p2", s.sport_id, DateTime.Now.AddMonths(-1), DateTime.Now).ToList();

                //Get Teams
                List<Team> t = db.Database.SqlQuery<Team>("EXEC GetTeams @p0", s.sport_id).ToList();

                // Get lowest prices for each team with given sport ID
                List<Price> p = db.Database.SqlQuery<Price>("EXEC GetLowestSportPrices @p0", s.sport_id).ToList();

                SportViewModel svm = new SportViewModel
                {
                    sport = s,
                    content = c,
                    prices = p,
                    teams = t
                };

                return View(svm);
            }
            catch
            {
                // The sport does not exist, return generic view
                return RedirectToAction("Index", "Home");
            }            
        }
    }
}