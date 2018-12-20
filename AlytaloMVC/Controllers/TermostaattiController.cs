using AlytaloMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlytaloMVC.Controllers
{
    public class TermostaattiController : Controller
    {
        // GET: Termostaatti
        public ActionResult Index()
        {
            KurssitehtavaEntities1 db = new KurssitehtavaEntities1();
            {
                var termostaatti = from t in db.Termostaatti
                            select t;

                return View(termostaatti.ToList());

            }
        }
    }
}