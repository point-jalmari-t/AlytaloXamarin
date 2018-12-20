using AlytaloMVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlytaloMVC.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            KurssitehtavaEntities1 db = new KurssitehtavaEntities1();
            {
                var sauna = from s in db.Sauna
                            select s;

                return View(sauna.ToList());

            }
        }

            public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}