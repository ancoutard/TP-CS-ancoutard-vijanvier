using ClientLourd.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLourd.ViewModels
{
    class HomeViewModel : BaseViewModel
    {
        #region Variables

        private ListeEmployeViewModel _listeEmployeViewModel = null;
        private ListeOffreViewModel _listeOffreViewModel = null;
        private ListePostulationViewModel _listePostulationViewModel = null;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public HomeViewModel()
        {
            _listeEmployeViewModel = new ListeEmployeViewModel();
            _listeOffreViewModel = new ListeOffreViewModel();
            _listePostulationViewModel = new ListePostulationViewModel();
        }

        #endregion

        #region Data Bindings

        /// <summary>
        /// Obtient ou définit le ListeEmployeViewModel
        /// </summary>
        public ListeEmployeViewModel ListeEmployeViewModel
        {
            get { return _listeEmployeViewModel; }
            set { _listeEmployeViewModel = value; }
        }

        public ListeOffreViewModel ListeOffreViewModel
        {
            get { return _listeOffreViewModel; }
            set { _listeOffreViewModel = value; }
        }
        public ListePostulationViewModel ListePostulationViewModel
        {
            get { return _listePostulationViewModel; }
            set { _listePostulationViewModel = value; }
        }

        #endregion
    }
}
