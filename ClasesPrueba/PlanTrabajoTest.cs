using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitsTest.Tests
{
    [TestClass]
    public class PlanTrabajoTest
    {
        [TestMethod]
        public void MetodosGuardar()
        {
            var metodo = "12123156984894449849849844989";

            var actual = PlanTrabajo.AgregarMetodos(metodo);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void RecursosGuardar()
        {
            var recurso = "598481561564985156s156adasdasd";

            var actual = PlanTrabajo.AgregarRecursos(recurso);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void DesarrolloClaseGuardar()
        {
            var desarrollo = "Programacion Orientada A Objetos";
            var tiempoMinutos = 30;

            var actual = PlanTrabajo.AgregarDesarrolloClase(desarrollo, tiempoMinutos);

            Assert.AreEqual(true, actual);
        }
    }
}