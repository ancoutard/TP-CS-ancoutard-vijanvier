using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Entities
{
    public class Experience
    {
        public int Id { get; set; }
        public int IdEmploye { get; set; }
        public String Intitule { get; set; }
        public DateTime Date { get; set; }
        public Employe Employe { get; set; }

    }
}
