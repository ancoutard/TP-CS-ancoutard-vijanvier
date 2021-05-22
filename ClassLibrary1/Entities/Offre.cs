using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Entities
{
    public class Offre
    {
        public int Id { get; set; }
        public String Intitule { get; set; }
        public DateTime Date { get; set; }
        public float Salaire { get; set; }
        public String Description { get; set; }
        public int IdStatus { get; set; }
        public Statut Statut { get; set; }
        public String Responsable { get; set; }

        public ICollection<Postulation> Postulations { get; set; }
    }
}
