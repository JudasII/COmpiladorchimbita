using ManejadorArchivo.AnalisisLexico;
using System;
using System.Collections.Generic;

namespace ManejadorArchivo.Transversal
{
    public class TablaErrores
    {
        private static TablaErrores INSTANCE = new TablaErrores();
        private Dictionary<String, List<Error>> tabla = new Dictionary<string, List<Error>>();
        private TablaErrores()
        {
            tabla.Add("LEXICOS", new List<Error>());
            tabla.Add("SINTACTICOS", new List<Error>());
            tabla.Add("SEMANTICOS", new List<Error>());
        }

        public static TablaErrores obtenerInstancia()
        {
            return INSTANCE;
        }

        public void comprobarSiEsError(Error error)
        {
            if (error != null && tabla.ContainsKey(error.Tipo))
            {
                tabla[error.Tipo].Add(error);

            }
        }

    }
}
