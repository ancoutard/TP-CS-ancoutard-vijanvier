﻿using ASP.NETMVC.Models;
using BusinessLogicLayer;
using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NETMVC.Controllers
{
    public class EditController : Controller
    {
        // GET: Edit
        public ActionResult Index(int id)
        {
            Offre off = Manager.Instance.GetByIdOffre(id);
            StatutViewModel statutVM = new StatutViewModel
            {
                Id = off.Statut.Id,
                Libelle = off.Statut.Libelle
            };
            List<PostulationViewModel> liste = new List<PostulationViewModel>();
            foreach(Postulation p in off.Postulations)
            {
                Employe emp = Manager.Instance.GetByIdEmploye(p.IdEmploye);
                liste.Add(new PostulationViewModel
                {
                    Date = p.Date,
                    IdEmploye = p.IdEmploye,
                    IdOffre = p.IdOffre,
                    Statut = p.Statut
                });
            }
            OffreViewModel ovm = new OffreViewModel
            {
                Id = off.Id,
                Intitule = off.Intitule,
                Description = off.Description,
                Date = off.Date,
                IdStatus = off.IdStatus,
                Responsable = off.Responsable,
                Salaire = off.Salaire,
                Postulations = liste,
                Statut = statutVM
            };
            return View(ovm);
        }

        public ActionResult Save(OffreViewModel off)
        {

            Statut statut = Manager.Instance.GetByIdStatut(off.IdStatus);
            List<Postulation> liste = new List<Postulation>();
            off.Postulations.ForEach(p =>
            {
                Employe emp = Manager.Instance.GetByIdEmploye(p.IdEmploye);
                liste.Add(new Postulation
                {
                    Date = p.Date,
                    Employe = emp,
                    IdEmploye = p.IdEmploye,
                    IdOffre = p.IdOffre,
                    Statut = p.Statut
                });
            });
            
            Offre offre = new Offre
            {
                Id = off.Id,
                Intitule = off.Intitule,
                Description = off.Description,
                Date = off.Date,
                IdStatus = off.IdStatus,
                Responsable = off.Responsable,
                Salaire = off.Salaire,
                Postulations = liste,
                Statut = statut
            };
            Manager.Instance.EditOffre(offre);
            return RedirectToAction("Index", "Home");
        }
    }
}