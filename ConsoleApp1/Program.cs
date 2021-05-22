using ClassLibrary1;
using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContextDB contexte = new ContextDB();
                List<Offre> offres = contexte.Offres.ToList();
                Console.WriteLine("Hello");
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
