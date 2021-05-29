using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary1.Entities;
using BusinessLogicLayer.Queries;

namespace BusinessLogicLayer
{
    public class Manager
    {
        private static Manager _instance = null;
        private ContextDB _context;
        private Manager()
        {
            _context = new ContextDB();
        }

        public static Manager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Manager();
                }
                { return _instance; }
            }
        }


        public List<Employe> GetAllEmploye()
        {
            EmployeQuery eq = new EmployeQuery(_context);
            return eq.GetAll().ToList();
        }

        public List<Experience> GetAllExperience()
        {
            ExperienceQuery eq = new ExperienceQuery(_context);
            return eq.GetAll().ToList();
        }

        public List<Formation> GetAllFormation()
        {
            FormationQuery fq = new FormationQuery(_context);
            return fq.GetAll().ToList();
        }

        public List<Offre> GetAllOffre()
        {
            OffreQuery oq = new OffreQuery(_context);
            return oq.GetAll().ToList();
        }

        public List<Postulation> GetAllPostulation()
        {
            PostulationQuery pq = new PostulationQuery(_context);
            return pq.GetAll().ToList();
        }
        public List<Statut> GetAllStatut()
        {
            StatutQuery sq = new StatutQuery(_context);
            return sq.GetAll().ToList();
        }
    }
}
