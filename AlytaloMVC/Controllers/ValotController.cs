using AlytaloMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlytaloMVC.Controllers
{
    public class ValotController : Controller
    {
        // GET: Valot
        public ActionResult Index()
        {
            KurssitehtavaEntities1 db = new KurssitehtavaEntities1();
            {
                var valot = from v in db.Valot
                            select v;

                return View(valot.ToList());

            }
        }
    }
}