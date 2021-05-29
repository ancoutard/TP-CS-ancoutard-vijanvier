using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary1.Entities;


namespace BusinessLogicLayer.Queries
{
    public class FormationQuery
    {
        /// <summary>
        /// QUERY pour récupérer des entités de types Formation
        /// </summary>
        private readonly ContextDB _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public FormationQuery(ContextDB contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Récupérer tous les formation
        /// </summary>
        /// <returns>IQueryable de Formation</returns>
        public IQueryable<Formation> GetAll()
        {
            return _contexte.Formations;
        }

        /// <summary>
        /// Récupérer un formation par son ID
        /// </summary>
        /// <param name="id">Identifiant du formation à récupérer</param>
        /// <returns>IQueryable de Formation</returns>
        public IQueryable<Formation> GetByID(int id)
        {
            return _contexte.Formations.Where(f => f.Id == id);
        }
    }
}
