using ASP.NETMVC.Models;
using BusinessLogicLayer;
using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NETMVC.Controllers
{
    public class DetailController : Controller
    {
        // GET: Detail
        public ActionResult Index(int id)
        {
            Offre off = Manager.Instance.GetByIdOffre(id);
            StatutViewModel statutVM = new StatutViewModel
            {
                Id = off.Statut.Id,
                Libelle = off.Statut.Libelle
            };
            OffreViewModel ovm = new OffreViewModel
            {
                Intitule = off.Intitule,
                Description = off.Description,
                Date = off.Date,
                IdStatus = off.IdStatus,
                Responsable = off.Responsable,
                Salaire = off.Salaire,
                Statut = statutVM
            };
            return View(ovm);
        }
    }
}