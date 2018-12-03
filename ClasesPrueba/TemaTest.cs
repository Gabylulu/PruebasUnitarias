using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitsTest.Tests
{
    [TestClass]
    public class TemaTest
    {
        [TestMethod]
        public void TemaGuardar()
        {
            var nombre = "Programacion Orientada A Objetos";

            var actual = Temas.AgregarTema(nombre);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SubTemaGuardar()
        {
            var tema = "TEMA 1";
            var nombre = "SUBTEMA";

            var actual = Temas.AgregarSubTema(tema, nombre);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void ObjetivoGuardar()
        {
            var objetivo = "Determinar las características diferenciales de la producción...";

            var actual = Temas.AgregarObjetivo(objetivo);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void EjeGuardar()
        {
            var eje = "El desarrollo de valores humanos universales, el cumplimiento...";

            var actual = Temas.AgregarEjeTransversal(eje);

            Assert.AreEqual(true, actual);
        }
    }
}
