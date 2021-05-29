using BusinessLogicLayer;
using ClassLibrary1.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestBLL
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetAllEmploye_RetoureListEmploye()
        {
            Manager manager = Manager.Instance;
            Assert.IsInstanceOfType(manager.GetAllEmploye(), typeof(List<Employe>));
        }
    }
}
