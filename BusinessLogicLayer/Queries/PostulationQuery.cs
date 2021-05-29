using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary1.Entities;


namespace BusinessLogicLayer.Queries
{
    public class PostulationQuery
    {
        /// <summary>
        /// QUERY pour récupérer des entités de types Postulation
        /// </summary>
        private readonly ContextDB _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public PostulationQuery(ContextDB contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Récupérer tous les postulation
        /// </summary>
        /// <returns>IQueryable de Postulation</returns>
        public IQueryable<Postulation> GetAll()
        {
            return _contexte.Postulations;
        }

        /// <summary>
        /// Récupérer un postulation par son ID
        /// </summary>
        /// <param name="id">Identifiant du postulation à récupérer</param>
        /// <returns>IQueryable de Postulation</returns>
        public IQueryable<Postulation> GetByID(int id)
        {
            return _contexte.Postulations.Where(p => p.IdOffre == id);
        }
    }
}
