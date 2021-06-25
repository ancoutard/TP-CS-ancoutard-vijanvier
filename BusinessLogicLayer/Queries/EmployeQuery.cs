using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary1.Entities;


namespace BusinessLogicLayer.Queries
{
    public class EmployeQuery
    {
        /// <summary>
        /// QUERY pour récupérer des entités de types Employe
        /// </summary>
        private readonly ContextDB _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public EmployeQuery(ContextDB contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Récupérer tous les employe
        /// </summary>
        /// <returns>IQueryable de Employe</returns>
        public IQueryable<Employe> GetAll()
        {
            return _contexte.Employes;
        }

        /// <summary>
        /// Récupérer un employe par son ID
        /// </summary>
        /// <param name="id">Identifiant du employe à récupérer</param>
        /// <returns>IQueryable de Employe</returns>
        public IQueryable<Employe> GetByID(int id)
        {
            return _contexte.Employes.Where(e => e.Id == id).Include("Postulations");
        }
    }
}
