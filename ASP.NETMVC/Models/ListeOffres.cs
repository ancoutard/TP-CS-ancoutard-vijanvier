using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClassLibrary1.Entities;
using BusinessLogicLayer;

namespace ASP.NETMVC.Models
{
    public class ListeOffres
    {
        public List<Offre> Offres { get; set; }

        public ListeOffres()
        {
        }

        public ListeOffres(List<Offre> offres)
        {
            Offres = offres;
        }

    }
}