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
                manager.AddEmploye(new Employe {Nom = "Janv", Prenom = "Victor", Anciennete = 2, Biographie = "Pas tres grand", DateNaissance = new DateTime(2000, 9, 11) });
                manager.AddEmploye(new Employe {Nom = "Cout", Prenom = "Antoine", Anciennete = 1, Biographie = "Pas pas tres grand", DateNaissance = new DateTime(2000, 12, 6) });
                manager.AddEmploye(new Employe {Nom = "Arno", Prenom = "Tristan", Anciennete = 7, Biographie = "Vraiment pas tres grand", DateNaissance = new DateTime(2000, 10, 9) });

            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
