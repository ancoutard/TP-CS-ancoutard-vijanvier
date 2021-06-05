using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary1.Entities;

namespace BusinessLogicLayer.Commands
{
    public class OffreCommand
    {
        private readonly ContextDB _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public OffreCommand(ContextDB contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Ajouter le Offre en base à partir du contexte
        /// </summary>
        /// <param name="o">offre à ajouter</param>
        /// <returns>Identifiant du offre ajouté</returns>
        public int Ajouter(Offre o)
        {
            _contexte.Offres.Add(o);
            return _contexte.SaveChanges();
        }

        /// <summary>
        /// Modifier une offre déjà présent en base à partir du contexte
        /// </summary>
        /// <param name="o">Offre à modifier</param>
        public void Modifier(Offre o)
        {
            Offre upOff = _contexte.Offres.Where(off => off.Id == o.Id).FirstOrDefault();
            if (upOff != null)
            {
                upOff.Intitule = o.Intitule;
                upOff.Date = o.Date;
                upOff.Salaire = o.Salaire;
                upOff.Description = o.Description;
                upOff.Responsable = o.Responsable;
                upOff.Postulations = o.Postulations;
                upOff.IdStatus = o.IdStatus;
                upOff.Statut = o.Statut;
            }
            _contexte.SaveChanges();
        }

        /// <summary>
        /// Supprimer un offre en base à partir du contexte et de son identifiant
        /// </summary>
        /// <param name="offreID">Identifiant du offre à supprimer</param>
        public void Supprimer(int offreID)
        {
            Offre delOff = _contexte.Offres.Where(off => off.Id == offreID).FirstOrDefault();
            if (delOff != null)
            {
                _contexte.Offres.Remove(delOff);
            }
            _contexte.SaveChanges();
        }
    }
}
