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
    class ListePostulationViewModel : BaseViewModel
    {
        #region Variables

        private ObservableCollection<DetailPostulationViewModel> _postulations = null;
        private DetailPostulationViewModel _selectedPostulation;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public ListePostulationViewModel()
        {
            _postulations = new ObservableCollection<DetailPostulationViewModel>();
            foreach (Postulation e in Manager.Instance.GetAllPostulation())
            {
                _postulations.Add(new DetailPostulationViewModel(e));
            }

            if (_postulations != null && _postulations.Count > 0)
                _selectedPostulation = _postulations.ElementAt(0);
        }

        #endregion

        #region Data Bindings

        /// <summary>
        /// Obtient ou définit une collection de DetailPostulationViewModel (Observable)
        /// </summary>
        public ObservableCollection<DetailPostulationViewModel> Postulations
        {
            get { return _postulations; }
            set
            {
                _postulations = value;
                OnPropertyChanged("Postulations");
            }
        }

        /// <summary>
        /// Obtient ou défini l'Postulation en cours de sélection dans la liste de DetailPostulationViewModel
        /// </summary>
        public DetailPostulationViewModel SelectedPostulation
        {
            get { return _selectedPostulation; }
            set
            {
                _selectedPostulation = value;
                OnPropertyChanged("SelectedPostulation");
            }
        }
        #endregion
    }

}
