using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary1.Entities;


namespace BusinessLogicLayer.Queries
{
    public class OffreQuery
    {
        /// <summary>
        /// QUERY pour récupérer des entités de types Offre
        /// </summary>
        private readonly ContextDB _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public OffreQuery(ContextDB contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Récupérer tous les offre
        /// </summary>
        /// <returns>IQueryable de Offre</returns>
        public IQueryable<Offre> GetAll()
        {
            return _contexte.Offres;
        }

        /// <summary>
        /// Récupérer un offre par son ID
        /// </summary>
        /// <param name="id">Identifiant du offre à récupérer</param>
        /// <returns>IQueryable de Offre</returns>
        public IQueryable<Offre> GetByID(int id)
        {
            return _contexte.Offres.Where(o => o.Id == id);
        }
    }
}
