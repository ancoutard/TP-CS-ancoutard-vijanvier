using BusinessLogicLayer;
using ClassLibrary1.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestBLL
{
    [TestClass]
    public class TestEmploye
    {
        [TestMethod]
        public void GetAllEmploye_RetoureListEmploye()
        {
            Manager manager = Manager.Instance;
            Assert.IsInstanceOfType(manager.GetAllEmploye(), typeof(List<Employe>));
        }

        [TestMethod]
        public void AddEmploye_RetrouneInt()
        {
            Manager manager = Manager.Instance;
            int ret = manager.AddEmploye(new Employe { Id = 1, Nom = "Janv", Prenom = "Victor", Anciennete = 2, Biographie = "Pas tres grand", DateNaissance = new DateTime(2000, 9, 11) });
            Assert.AreEqual(1, ret);
        }

        [TestMethod]
        public void EditEmploye_RetrouneRien()
        {
            Manager manager = Manager.Instance;
            //int ret = manager.AddEmploye(new Employe { Id = 999, Nom = "Janv", Prenom = "Victor", Anciennete = 2, Biographie = "Pas tres grand", DateNaissance = new DateTime(2000, 9, 11) });
            Employe employe = manager.GetByIdEmploye(1);
            employe.Nom = "Antoine";
            manager.EditEmploye(employe);
            Employe employeNew = manager.GetByIdEmploye(1);
            Assert.AreEqual("Antoine", employeNew.Nom);
            //manager.DeleteEmploye(999);
        }

        [TestMethod]
        public void FDeleteEmploye_RetrouneRien()
        {
            Manager manager = Manager.Instance;
            manager.DeleteEmploye(1);
            Employe employeNew = manager.GetByIdEmploye(1);
            Assert.AreEqual(null, employeNew);
        }
    }
}
