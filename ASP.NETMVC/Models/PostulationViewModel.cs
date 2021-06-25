using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NETMVC.Models
{
    public class PostulationViewModel
    {
        public int IdOffre { get; set; }
        public int IdEmploye { get; set; }
        public DateTime Date { get; set; }
        public String Statut { get; set; }
        public OffreViewModel Offre { get; set; }


    }
}