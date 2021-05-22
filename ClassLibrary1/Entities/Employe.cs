using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Entities
{
    public class Employe
    {
        public int Id { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public int Anciennete { get; set; }
        public String Biographie { get; set; }
        public ICollection<Postulation> Postulations { get; set; }
        public ICollection<Formation> Formations { get; set; }
        public ICollection<Experience> Experiences { get; set; }

    }
}
