using AlytaloMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlytaloMVC.Controllers
{
    public class SaunaController : Controller
    {
        // GET: Sauna
        public ActionResult Index()
        {
            KurssitehtavaEntities1 db = new KurssitehtavaEntities1();
            {
                var sauna = from s in db.Sauna
                            select s;

                return View(sauna.ToList());

            }
        }
    }
}