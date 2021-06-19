using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NETMVC.Models
{
    public class OffreViewModel
    {
        public int Id { get; set; }
        public String Intitule { get; set; }
        public DateTime Date { get; set; }
        public float Salaire { get; set; }
        public String Description { get; set; }
        public int IdStatus { get; set; }
        public StatutViewModel Statut { get; set; }
        public String Responsable { get; set; }
    }
}