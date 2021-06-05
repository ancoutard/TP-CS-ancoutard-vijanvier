using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Entities
{
    public class Statut
    {
        public int Id { get; set; }
        public String Libelle { get; set; }
        public ICollection<Offre> Offres { get; set; }

        public override string ToString()
        {
            return Libelle;
        }
    }
}
