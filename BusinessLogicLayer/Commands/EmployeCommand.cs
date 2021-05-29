using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary1.Entities;

namespace BusinessLogicLayer.Commands
{
    public class EmployeCommand
    {
        private readonly ContextDB _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public EmployeCommand(ContextDB contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Ajouter le employe en base à partir du contexte
        /// </summary>
        /// <param name="e">Employe à ajouter</param>
        /// <returns>Identifiant du employe ajouté</returns>
        public int Ajouter(Employe e)
        {
            _contexte.Employes.Add(e);
            return _contexte.SaveChanges();
        }

        /// <summary>
        /// Modifier un employe déjà présent en base à partir du contexte
        /// </summary>
        /// <param name="e">Employe à modifier</param>
        public void Modifier(Employe e)
        {
            Employe upEmp = _contexte.Employes.Where(emp => emp.Id == e.Id).FirstOrDefault();
            if (upEmp != null)
            {
                upEmp.Nom = e.Nom;
                upEmp.Prenom = e.Prenom;
                upEmp.DateNaissance = e.DateNaissance;
                upEmp.Anciennete = e.Anciennete;
                upEmp.Biographie = e.Biographie;
                upEmp.Postulations = e.Postulations;
                upEmp.Formations = e.Formations; 
                upEmp.Experiences = e.Experiences;
            }
            _contexte.SaveChanges();
        }

        /// <summary>
        /// Supprimer un employe en base à partir du contexte et de son identifiant
        /// </summary>
        /// <param name="employeID">Identifiant du employe à supprimer</param>
        public void Supprimer(int employeID)
        {
            Employe delEmp = _contexte.Employes.Where(emp => emp.Id == employeID).FirstOrDefault();
            if (delEmp != null)
            {
                _contexte.Employes.Remove(delEmp);
            }
            _contexte.SaveChanges();
        }
    }
}
