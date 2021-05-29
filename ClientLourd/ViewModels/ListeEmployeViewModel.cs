using BusinessLogicLayer;
using ClassLibrary1.Entities;
using ClientLourd.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLourd.ViewModels
{
    class ListeEmployeViewModel : BaseViewModel
    {
        #region Variables

        private ObservableCollection<DetailEmployeViewModel> _employes = null;
        private DetailEmployeViewModel _selectedEmploye;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public ListeEmployeViewModel()
        {
            _employes = new ObservableCollection<DetailEmployeViewModel>();
            foreach (Employe e in Manager.Instance.GetAllEmploye())
            {
                _employes.Add(new DetailEmployeViewModel(e));
            }

            if (_employes != null && _employes.Count > 0)
                _selectedEmploye = _employes.ElementAt(0);
        }

        #endregion

        #region Data Bindings

        /// <summary>
        /// Obtient ou définit une collection de DetailEmployeViewModel (Observable)
        /// </summary>
        public ObservableCollection<DetailEmployeViewModel> Employes
        {
            get { return _employes; }
            set
            {
                _employes = value;
                OnPropertyChanged("Employes");
            }
        }

        /// <summary>
        /// Obtient ou défini l'Employe en cours de sélection dans la liste de DetailEmployeViewModel
        /// </summary>
        public DetailEmployeViewModel SelectedEmploye
        {
            get { return _selectedEmploye; }
            set
            {
                _selectedEmploye = value;
                OnPropertyChanged("SelectedEmploye");
            }
        }


        #endregion
    }
}
