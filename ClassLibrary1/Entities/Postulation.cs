using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Entities
{
    public class Postulation
    {
        public int IdOffre { get; set; }
        public int IdEmploye { get; set; }
        public DateTime Date { get; set; }
        public String Statut { get; set; }

        public Offre Offre { get; set; }
        public Employe Employe { get; set; }
    }
}
