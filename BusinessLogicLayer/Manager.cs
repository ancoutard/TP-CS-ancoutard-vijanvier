using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary1.Entities;
using BusinessLogicLayer.Queries;
using BusinessLogicLayer.Commands;

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

        public Employe GetByIdEmploye(int id)
        {
            EmployeQuery eq = new EmployeQuery(_context);
            return eq.GetByID(id).FirstOrDefault();
        }

        public int AddEmploye(Employe e)
        {
            EmployeCommand ec = new EmployeCommand(_context);
            return ec.Ajouter(e);
        }

        public void EditEmploye(Employe e)
        {
            EmployeCommand ec = new EmployeCommand(_context);
            ec.Modifier(e);
        }

        public void DeleteEmploye(int id)
        {
            EmployeCommand ec = new EmployeCommand(_context);
            ec.Supprimer(id);
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
