using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary1.Entities;

namespace BusinessLogicLayer.Commands
{
    public class PostulationCommand
    {
        private readonly ContextDB _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public PostulationCommand(ContextDB contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Ajouter le Postulation en base à partir du contexte
        /// </summary>
        /// <param name="p">postulation à ajouter</param>
        /// <returns>Identifiant du Postulation ajouté</returns>
        public int Ajouter(Postulation p)
        {
            Employe emp = Manager.Instance.GetByIdEmploye(p.IdEmploye);
            if (emp.Postulations.Where(post => post.IdOffre == p.IdOffre).Count() > 0)
            {
                throw new Exception("Duplication de postulation");
            }
            _contexte.Postulations.Add(p);
            return _contexte.SaveChanges();
        }

        /// <summary>
        /// Modifier une postulation déjà présent en base à partir du contexte
        /// </summary>
        /// <param name="p">Postulation à modifier</param>
        public void Modifier(Postulation p)
        {
            Postulation upPost = _contexte.Postulations.Where(post => post.IdEmploye == p.IdEmploye && post.IdOffre == p.IdOffre).FirstOrDefault();
            if (upPost != null)
            {
                upPost.Statut = p.Statut;
                upPost.Date = p.Date;
                upPost.Employe = p.Employe;
                upPost.Offre = p.Offre;
            }
            _contexte.SaveChanges();
        }

        /// <summary>
        /// Supprimer un postulation en base à partir du contexte et de son identifiant
        /// </summary>
        /// <param name="postulationID">Identifiant du postulation à supprimer</param>
        public void Supprimer(int postulationOffreID, int postulationEmployeID)
        {
            Postulation delPost = _contexte.Postulations.Where(post => post.IdOffre == postulationOffreID && post.IdEmploye == postulationEmployeID).FirstOrDefault();
            if (delPost != null)
            {
                _contexte.Postulations.Remove(delPost);
            }
            _contexte.SaveChanges();
        }
    }
}
