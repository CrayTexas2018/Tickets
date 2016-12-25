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
        public ActionResult Index(string sport)
        {
            db = new ApplicationDbContext();
            try
            {
                // Check if sport is in database
                Sport s = db.Database.SqlQuery<Sport>("EXEC GetSportData @p0", sport).Single();

                // Get content and prices for that sport ID
                

            }
            catch
            {
                // The sport does not exist
            }

            return View();
        }
    }
}