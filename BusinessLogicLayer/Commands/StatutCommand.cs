using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary1.Entities;

namespace BusinessLogicLayer.Commands
{
    public class StatutCommand
    {
        private readonly ContextDB _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public StatutCommand(ContextDB contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Ajouter le Statut en base à partir du contexte
        /// </summary>
        /// <param name="s">statut à ajouter</param>
        /// <returns>Identifiant du Statut ajouté</returns>
        public int Ajouter(Statut s)
        {
            _contexte.Statuts.Add(s);
            return _contexte.SaveChanges();
        }

        /// <summary>
        /// Modifier une statut déjà présent en base à partir du contexte
        /// </summary>
        /// <param name="s">Statut à modifier</param>
        public void Modifier(Statut s)
        {
            Statut upStat = _contexte.Statuts.Where(stat => stat.Id == s.Id).FirstOrDefault();
            if (upStat != null)
            {
                upStat.Libelle = s.Libelle;
                upStat.Offres = s.Offres;
            }
            _contexte.SaveChanges();
        }

        /// <summary>
        /// Supprimer un statut en base à partir du contexte et de son identifiant
        /// </summary>
        /// <param name="statutID">Identifiant du statut à supprimer</param>
        public void Supprimer(int statutID)
        {
            Statut delStat = _contexte.Statuts.Where(stat => stat.Id == statutID).FirstOrDefault();
            if (delStat != null)
            {
                _contexte.Statuts.Remove(delStat);
            }
            _contexte.SaveChanges();
        }
    }
}
