using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace commitFive.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        private commit_fiveEntities db = new commit_fiveEntities();
        

        public ActionResult Index()
        {
            //student -> 


            var x = db.campusReference.Where(c => c.CAMPUS=="'057905017")
                .Select(c => new {  
                    //campus = c.CAMPNAME,
                    //staar = c.college.Where(c.college.)

                });


            return View(db.campusReference.ToList());
            //return View(db.campusReference.ToList());
        }
    }
}