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
    class ListeOffreViewModel : BaseViewModel
    {
        #region Variables

        private ObservableCollection<DetailOffreViewModel> _offres = null;
        private ObservableCollection<Statut> _statuts = null;
        private DetailOffreViewModel _selectedOffre;
        private Statut _selectStatut;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public ListeOffreViewModel()
        {
            _offres = new ObservableCollection<DetailOffreViewModel>();
            _statuts = new ObservableCollection<Statut>();
            foreach (Offre o in Manager.Instance.GetAllOffre())
            {
                _offres.Add(new DetailOffreViewModel(o));
            }

            foreach(Statut s in Manager.Instance.GetAllStatut())
            {
                _statuts.Add(s);
            }

            if (_offres != null && _offres.Count > 0)
                _selectedOffre = _offres.ElementAt(0);
        }

        #endregion

        #region Data Bindings

        /// <summary>
        /// Obtient ou définit une collection de DetailOffreViewModel (Observable)
        /// </summary>
        public ObservableCollection<DetailOffreViewModel> Offres
        {
            get { return _offres; }
            set
            {
                _offres = value;
                OnPropertyChanged("Offres");
            }
        }

        /// <summary>
        /// Obtient ou défini l'Offre en cours de sélection dans la liste de DetailOffreViewModel
        /// </summary>
        public DetailOffreViewModel SelectedOffre
        {
            get { return _selectedOffre; }
            set
            {
                _selectedOffre = value;
                OnPropertyChanged("SelectedOffre");
            }
        }

        public ObservableCollection<Statut> Statuts
        {
            get { return _statuts; }
            set
            {
                _statuts = value;
                OnPropertyChanged("Statuts");
            }
        }

        public Statut SelectedStatut
        {
            get { return _selectStatut; }
            set
            {
                ObservableCollection<DetailOffreViewModel> newOffres = new ObservableCollection<DetailOffreViewModel>();
                foreach (Offre o in Manager.Instance.GetAllOffre().Where(o => o.Statut == value).ToList())
                {
                    newOffres.Add(new DetailOffreViewModel(o));
                }
                _offres = newOffres;

                _selectStatut = value;
                OnPropertyChanged("SelectedStatut");
                OnPropertyChanged("Offres");
            }
        }


        #endregion
    }
}
