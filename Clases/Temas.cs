using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitsTest
{
    public class Temas
    {

        public static List<string> temas = new List<string>();

        public static bool AgregarTema(string nombre)
        {
            bool comprobacion = true;

            if (nombre == null || nombre == "" || nombre.Length < 5)
            {
                comprobacion = false;
            }

            return comprobacion;
        }


        public static bool AgregarSubTema(string tema, string nombre)
        {
            bool comprobacion = true;

            temas.Add("TEMA 1");
            temas.Add("TEMA 2");
            temas.Add("TEMA 3");

            string temasResultados = temas.FirstOrDefault(s => s == tema);

            if (temasResultados == null)
            {
                comprobacion = false;
            }
            else if (nombre == null || nombre == "" || nombre.Length < 5)
            {
                comprobacion = false;
            }


            return comprobacion;
        }

        public static bool AgregarObjetivo(string objetivo)
        {
            bool comprobacion = true;

            if (objetivo == null || objetivo == "" || objetivo.Length < 10)
            {
                comprobacion = false;
            }

            return comprobacion;
        }

        public static bool AgregarEjeTransversal(string eje)
        {
            bool comprobacion = true;

            if (eje == null || eje == "" || eje.Length < 10)
            {
                comprobacion = false;
            }

            return comprobacion;
        }
    }
}