using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary1.Entities;

namespace BusinessLogicLayer.Commands
{
    public class FormationCommand
    {
        private readonly ContextDB _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public FormationCommand(ContextDB contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Ajouter le formation en base à partir du contexte
        /// </summary>
        /// <param name="f">Formation à ajouter</param>
        /// <returns>Identifiant d'une formation ajouté</returns>
        public int Ajouter(Formation f)
        {
            _contexte.Formations.Add(f);
            return _contexte.SaveChanges();
        }

        /// <summary>
        /// Modifier une formation déjà présent en base à partir du contexte
        /// </summary>
        /// <param name="f">Formation à modifier</param>
        public void Modifier(Formation f)
        {
            Formation upFor = _contexte.Formations.Where(frm => frm.Id == f.Id).FirstOrDefault();
            if (upFor != null)
            {
                upFor.IdEmploye = f.IdEmploye;
                upFor.Intitule = f.Intitule;
                upFor.Date = f.Date;
                upFor.Employe = f.Employe;
            }
            _contexte.SaveChanges();
        }

        /// <summary>
        /// Supprimer une formation en base à partir du contexte et de son identifiant
        /// </summary>
        /// <param name="employeID">Identifiant d'une formation à supprimer</param>
        public void Supprimer(int formationID)
        {
            Formation delFor = _contexte.Formations.Where(frm => frm.Id == formationID).FirstOrDefault();
            if (delFor != null)
            {
                _contexte.Formations.Remove(delFor);
            }
            _contexte.SaveChanges();
        }
    }
}
