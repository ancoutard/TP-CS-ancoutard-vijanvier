using ClassLibrary1.Entities;
using ClientLourd.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLourd.ViewModels
{
    class DetailEmployeViewModel : BaseViewModel
    {
        #region Variables

        private string _nom;
        private string _prenom;
        //private DateTime _dateDeNaissance;
        private int _anciennete;
        private string _biographie;

        #endregion

        #region Constructeurs

        public DetailEmployeViewModel(Employe e)
        {
            _nom = e.Nom;
            _prenom = e.Prenom;
            _anciennete = e.Anciennete;
            _biographie = e.Biographie;
        }

        #endregion

        #region Data Bindings

        /// <summary>
        /// Nom de l'employe
        /// </summary>
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        /// <summary>
        /// Prenom de l'employe
        /// </summary>
        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }


        /// <summary>
        /// Anciennete de l'employe
        /// </summary>
        public int Anciennete
        {
            get { return _anciennete; }
            set { _anciennete = value; }
        }

        /// <summary>
        /// Biographie de l'employe
        /// </summary>
        public string Biographie
        {
            get { return _biographie; }
            set { _biographie = value; }
        }

        #endregion
    }
}
