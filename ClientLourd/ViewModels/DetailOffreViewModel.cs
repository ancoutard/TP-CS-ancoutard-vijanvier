﻿using System;
using BusinessLogicLayer;
using ClassLibrary1.Entities;
using ClientLourd.ViewModels.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ClientLourd.ViewModels
{
    class DetailOffreViewModel
    {
        #region Variables
        private int _id;
        private string _intitule;
        private int _idStatus;
        private DateTime _date;
        private float _salaire;
        private string _description;
        private string _responsable;
        private List<Postulation> _postulation;
        private Statut _statut;
        private RelayCommand _saveEntity;

        #endregion

        #region Constructeurs

        public DetailOffreViewModel(Offre e)
        {
            _id = e.Id;
            _intitule = e.Intitule;
            _responsable = e.Responsable;
            _salaire = e.Salaire;
            _description = e.Description;
            _statut = e.Statut;
            _date = e.Date;
            _idStatus = e.IdStatus;
            _postulation = (List<Postulation>)e.Postulations;
        }

        #endregion

        #region Data Bindings

        /// <summary>
        /// Intitule de l'offre
        /// </summary>
        public string Intitule
        {
            get { return _intitule; }
            set { _intitule = value; }
        }

        /// <summary>
        /// Responsable de l'offre
        /// </summary>
        public string Responsable
        {
            get { return _responsable; }
            set { _responsable = value; }
        }


        /// <summary>
        /// Salaire de l'offre
        /// </summary>
        public float Salaire
        {
            get { return _salaire; }
            set { _salaire = value; }
        }

        /// <summary>
        /// Description de l'offre
        /// </summary>
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>
        /// Statut de l'offre
        /// </summary>
        public Statut Statut
        {
            get { return _statut; }
            set { _statut = value; }
        }

        //public List<Postulation> Postulations
        //{
        //    get { return _postulation; }
        //    set { _postulation = value; }
        //}

        #endregion

        #region command
        public ICommand SaveEntity
        {
            get
            {
                if (_saveEntity == null)
                    _saveEntity = new RelayCommand(() => this.SaveCommand());
                return _saveEntity;
            }
        }
        private void SaveCommand()
        {
            Manager.Instance.EditOffre(new Offre { Id = _id, Description = _description, Statut = _statut, Intitule = _intitule, Salaire = _salaire, Responsable = _responsable, Date = _date, IdStatus = _idStatus, Postulations = _postulation });
        }
        #endregion
    }
}
