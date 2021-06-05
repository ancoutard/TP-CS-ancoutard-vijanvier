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

        public int AddOffre(Offre o)
        {
            OffreCommand off = new OffreCommand(_context);
            return off.Ajouter(o);
        }

        public void EditOffre(Offre o)
        {
            OffreCommand off = new OffreCommand(_context);
            off.Modifier(o);
        }

        public void DeleteOffre(int id)
        {
            OffreCommand off = new OffreCommand(_context);
            off.Supprimer(id);
        }

        public List<Postulation> GetAllPostulation()
        {
            PostulationQuery pq = new PostulationQuery(_context);
            return pq.GetAll().ToList();
        }

        public int AddPostulation(Postulation p)
        {
            PostulationCommand post = new PostulationCommand(_context);
            return post.Ajouter(p);
        }

        public void EditPostulation(Postulation p)
        {
            PostulationCommand post = new PostulationCommand(_context);
            post.Modifier(p);
        }

        public void DeletePostulation(int idOffre, int idEmploye)
        {
            PostulationCommand post = new PostulationCommand(_context);
            post.Supprimer(idOffre, idEmploye);
        }

        public List<Statut> GetAllStatut()
        {
            StatutQuery sq = new StatutQuery(_context);
            return sq.GetAll().ToList();
        }

        public int AddStatut(Statut s)
        {
            StatutCommand stat = new StatutCommand(_context);
            return stat.Ajouter(s);
        }

        public void EditStatut(Statut s)
        {
            StatutCommand stat = new StatutCommand(_context);
            stat.Modifier(s);
        }

        public void DeleteStatut(int id)
        {
            StatutCommand stat = new StatutCommand(_context);
            stat.Supprimer(id);
        }


    }
}
