using ASP.NETMVC.Models;
using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NETMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ListeOffres offres = new ListeOffres(Manager.Instance.GetAllOffre().ToList());
            return View(offres);
        }

        [HttpPost]
        public ActionResult IndexSearch(string searchTerm)
        {
            ListeOffres offres = new ListeOffres(Manager.Instance.GetAllOffre().Where(off => off.Intitule.ToUpper().Contains(searchTerm.ToUpper())).ToList());
            return View("Index", offres);
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