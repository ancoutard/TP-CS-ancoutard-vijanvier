using ClassLibrary1.Entities;
using ClientLourd.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLourd.ViewModels
{
    class DetailPostulationViewModel
    {
        #region Variables

        private string _statut;
        //private DateTime _date;
        private string _employeNom;
        private string _employePrenom;

        #endregion

        #region Constructeurs

        public DetailPostulationViewModel(Postulation p)
        {
            _statut = p.Statut;
            _employeNom = p.Employe.Nom;
            _employePrenom = p.Employe.Prenom;
        }

        #endregion

        #region Data Bindings

        /// <summary>
        /// Statut de l'postulation
        /// </summary>
        public string Statut
        {
            get { return _statut; }
            set { _statut = value; }
        }

        /// <summary>
        /// Employe de l'postulation
        /// </summary>
        public string EmployeNom
        {
            get { return _employeNom; }
            set { _employeNom = value; }
        }

        /// <summary>
        /// Employe de l'postulation
        /// </summary>
        public string EmployePrenom
        {
            get { return _employePrenom; }
            set { _employePrenom = value; }
        }
        #endregion

    }
}
