using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitsTest
{
    public class PlanTrabajo
    {

        public static bool AgregarMetodos(string metodo)
        {
            bool comprobacion = true;

            if (metodo == null || metodo == "" || metodo.Length < 10)
            {
                comprobacion = false;
            }

            return comprobacion;
        }

        public static bool AgregarRecursos(string recusros)
        {
            bool comprobacion = true;

            if (recusros == null || recusros == "" || recusros.Length < 10)
            {
                comprobacion = false;
            }

            return comprobacion;
        }

        public static bool AgregarDesarrolloClase(string desarrollo, int tiempoMinutos)
        {
            bool comprobacion = true;

            int MinutosClaseSemanal = 600;

            if (desarrollo == null || desarrollo == "" || desarrollo.Length < 10)
            {
                comprobacion = false;
            }else if (tiempoMinutos > MinutosClaseSemanal)
            {
                comprobacion = false;
            }

            return comprobacion;
        }
    }
}