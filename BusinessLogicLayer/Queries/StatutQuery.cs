using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary1.Entities;


namespace BusinessLogicLayer.Queries
{
    public class StatutQuery
    {
        /// <summary>
        /// QUERY pour récupérer des entités de types Statut
        /// </summary>
        private readonly ContextDB _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public StatutQuery(ContextDB contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Récupérer tous les statut
        /// </summary>
        /// <returns>IQueryable de Statut</returns>
        public IQueryable<Statut> GetAll()
        {
            return _contexte.Statuts;
        }

        /// <summary>
        /// Récupérer un statut par son ID
        /// </summary>
        /// <param name="id">Identifiant du statut à récupérer</param>
        /// <returns>IQueryable de Statut</returns>
        public IQueryable<Statut> GetByID(int id)
        {
            return _contexte.Statuts.Where(s => s.Id == id);
        }
    }
}
