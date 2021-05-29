using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary1.Entities;

namespace BusinessLogicLayer.Commands
{
    public class ExperienceCommand
    {
        private readonly ContextDB _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public ExperienceCommand(ContextDB contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Ajouter le experience en base à partir du contexte
        /// </summary>
        /// <param name="e">Experience à ajouter</param>
        /// <returns>Identifiant du experience ajouté</returns>
        public int Ajouter(Experience e)
        {
            _contexte.Experiences.Add(e);
            return _contexte.SaveChanges();
        }

        /// <summary>
        /// Modifier une experience déjà présent en base à partir du contexte
        /// </summary>
        /// <param name="e">Experience à modifier</param>
        public void Modifier(Experience e)
        {
            Experience upExp = _contexte.Experiences.Where(exp => exp.Id == e.Id).FirstOrDefault();
            if (upExp != null)
            {
                upExp.IdEmploye = e.IdEmploye;
                upExp.Intitule = e.Intitule;
                upExp.Date = e.Date;
                upExp.Employe = e.Employe;
            }
            _contexte.SaveChanges();
        }

        /// <summary>
        /// Supprimer une experience en base à partir du contexte et de son identifiant
        /// </summary>
        /// <param name="employeID">Identifiant du experience à supprimer</param>
        public void Supprimer(int experienceID)
        {
            Experience delExp = _contexte.Experiences.Where(emp => emp.Id == experienceID).FirstOrDefault();
            if (delExp != null)
            {
                _contexte.Experiences.Remove(delExp);
            }
            _contexte.SaveChanges();
        }
    }
}
