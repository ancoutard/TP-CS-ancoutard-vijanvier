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
    public class PostulationController : Controller
    {
        // GET: Postulation
        public ActionResult Index()
        {
            List<Postulation> listePost = Manager.Instance.GetAllPostulation().Where(p => p.IdEmploye == 1).ToList();
            List<PostulationViewModel> listePostVM = new List<PostulationViewModel>();
            ListeOffres listeOffresVM = new ListeOffres();
            listePost.ForEach(p =>
            {
                Offre off = Manager.Instance.GetByIdOffre(p.IdOffre);
                StatutViewModel statutVM = new StatutViewModel
                {
                    Id = off.Statut.Id,
                    Libelle = off.Statut.Libelle
                };
                OffreViewModel offreVM = new OffreViewModel
                {
                    Id = off.Id,
                    Intitule = off.Intitule,
                    Description = off.Description,
                    Date = off.Date,
                    IdStatus = off.IdStatus,
                    Responsable = off.Responsable,
                    Salaire = off.Salaire,
                    Statut = statutVM
                };
                listePostVM.Add(new PostulationViewModel
                {
                    IdEmploye = p.IdEmploye,
                    IdOffre = p.IdOffre,
                    Date = p.Date,
                    Statut = p.Statut,
                    Offre = offreVM
                });
            });
            return View(listePostVM);
        }

        public ActionResult Postuler(int idOff)
        {
            int idEmp = 1;
            Offre off = Manager.Instance.GetByIdOffre(idOff);
            Employe emp = Manager.Instance.GetByIdEmploye(idEmp);
            Postulation p = new Postulation
            {
                IdEmploye = idEmp,
                IdOffre = idOff,
                Offre = off,
                Employe = emp,
                Date = DateTime.Now,
                Statut = "En Cours"

            };
            try
            {
                Manager.Instance.AddPostulation(p);
            }catch(Exception e)
            {
                
            }
            return RedirectToAction("Index", "Postulation");
        }
    }
}