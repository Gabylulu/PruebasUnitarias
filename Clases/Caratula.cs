using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitsTest
{
    public class Caratula
    {
        public static List<string> institutos = new List<string>();
        public static List<string> asignaturas = new List<string>();
        public static List<string> docentes = new List<string>();

        public static bool AgregarCaratula(string instituto, string asignatura, string docente)
        {
            bool comprobacion = true;

            institutos.Add("Benito Juarez");
            asignaturas.Add("Ingenieria del Software");
            docentes.Add("Gorky Gomez");

            string institutoResultados = institutos.FirstOrDefault(s => s == instituto);
            string asignaturasResultados = asignaturas.FirstOrDefault(s => s == asignatura);
            string docentesResultados = docentes.FirstOrDefault(s => s == docente);

            if (institutoResultados == null)
            {
                comprobacion = false;
            }
            if (asignaturasResultados == null)
            {
                comprobacion = false;
            }
            if (docentesResultados == null)
            {
                comprobacion = false;
            }

            return comprobacion;
        }

    }
}