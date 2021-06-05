using ClassLibrary1;
using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Manager manager = Manager.Instance;
                List<Employe> liste = manager.GetAllEmploye();

                 Console.WriteLine(liste);
                //ContextDB contexte = new ContextDB();
                //List<Offre> offres = contexte.Offres.ToList();
                //Console.WriteLine("Hello");
                manager.AddStatut(new Statut { Libelle = "En cours" });
                manager.AddStatut(new Statut { Libelle = "Terminée" });
                manager.AddEmploye(new Employe {Nom = "Janv", Prenom = "Victor", Anciennete = 2, Biographie = "Pas tres grand", DateNaissance = new DateTime(2000, 9, 11) });
                manager.AddEmploye(new Employe {Nom = "Cout", Prenom = "Antoine", Anciennete = 1, Biographie = "Pas pas tres grand", DateNaissance = new DateTime(2000, 12, 6) });
                manager.AddEmploye(new Employe {Nom = "Arno", Prenom = "Tristan", Anciennete = 7, Biographie = "Vraiment pas tres grand", DateNaissance = new DateTime(2000, 10, 9) });
                Statut statut = manager.GetAllStatut().First();
                manager.AddOffre(new Offre { Intitule = "Developpeur Junior ASP .NET H/F", Salaire = 25785.5F, Description = "Si tu as envie d'en finir avec la vie viens donc nous rejoindre pour finir de t'achever en faisant de l'ASP .NET MVC mon roya", Responsable = "Clairement Monsieur MCH", Date = new DateTime(2020, 9, 11), Statut = statut }) ;
                manager.AddOffre(new Offre { Intitule = "Developpeur Junior React.Js H/F", Salaire = 45000.45F, Description = "Tu veux t'épanouir encore plus dans ta vie ? N'hésites pas à nous rejoindre pour pouvoir utiliser le meilleur langage avec le meilleur 'framework' au monde !!!", Responsable = "Monsieur Poulpe", Date = new DateTime(2021, 4, 6), Statut = statut });
                List<Employe> listeEmp = manager.GetAllEmploye();
                Offre offre = manager.GetAllOffre().First();
                listeEmp.ForEach(e =>
                {
                    manager.AddPostulation(new Postulation { Statut = "TMTC", Employe = e, Offre = offre, Date = DateTime.Now });
                });
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
