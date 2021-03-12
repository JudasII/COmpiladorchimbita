using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorArchivo.Transversal
{
    public class ManejadorErrores
    {
        private static ManejadorErrores INSTANCE = new ManejadorErrores();
        private Dictionary<String, List<Error>> mapaErrores = new Dictionary<string, List<Error>>();

        private ManejadorErrores() { }

        public static ManejadorErrores obtenerInstancia()
        {
            return INSTANCE;
        }

        public void agregar(Error error)
        {
            if (error != null)
            {
                if (mapaErrores.ContainsKey(error.Tipo))
                {
                    mapaErrores[error.Tipo].Add(error);
                }
                else
                {
                    List<Error> listaErrores = new List<Error>();
                    listaErrores.Add(error);
                    mapaErrores.Add(error.Tipo, listaErrores);
                }
            }
        }
        public List<Error> ObtenerTodo()
        {
            return mapaErrores.Values.SelectMany(simbolo => simbolo).ToList();

        }


        public Boolean hayErrores()
        {
            return mapaErrores.Count()>0;
        }



    }
}
