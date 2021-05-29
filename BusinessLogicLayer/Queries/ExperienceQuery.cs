using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary1.Entities;


namespace BusinessLogicLayer.Queries
{
    public class ExperienceQuery
    {
        /// <summary>
        /// QUERY pour récupérer des entités de types Experience
        /// </summary>
        private readonly ContextDB _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public ExperienceQuery(ContextDB contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Récupérer tous les experience
        /// </summary>
        /// <returns>IQueryable de Experience</returns>
        public IQueryable<Experience> GetAll()
        {
            return _contexte.Experiences;
        }

        /// <summary>
        /// Récupérer un experience par son ID
        /// </summary>
        /// <param name="id">Identifiant du experience à récupérer</param>
        /// <returns>IQueryable de Experience</returns>
        public IQueryable<Experience> GetByID(int id)
        {
            return _contexte.Experiences.Where(p => p.Id == id);
        }
    }
}
