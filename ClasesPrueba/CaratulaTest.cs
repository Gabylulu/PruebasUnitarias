using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitsTest.Tests;

namespace UnitsTest.Tests
{
    [TestClass]
    public class CaratulaTest
    {
        [TestMethod]
        public void CaratulaGuardar()
        {
            string instituto = "Benito Juarez";
            string asignatura = "Ingenieria del Software";
            string docente = "Gorky Gomez";

            var actual = Caratula.AgregarCaratula(instituto, asignatura, docente);

            Assert.AreEqual(true, actual);

        }
    }
}
