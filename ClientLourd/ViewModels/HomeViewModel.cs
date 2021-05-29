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

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public HomeViewModel()
        {
            _listeEmployeViewModel = new ListeEmployeViewModel();
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

        #endregion
    }
}
