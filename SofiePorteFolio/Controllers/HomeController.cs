using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SofiePorteFolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
         

            return PartialView();
        }

        public ActionResult Skills()
        {
            return PartialView();
        }

        public ActionResult Work()
        {
            return PartialView();
        }

        public ActionResult Portfolio()
        {
            return PartialView();
        }

        public ActionResult Contact()
        {
          

            return View();
        }
    }
}