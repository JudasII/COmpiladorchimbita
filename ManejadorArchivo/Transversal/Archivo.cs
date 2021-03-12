using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorArchivo.Transversal
{
    public class Archivo
    {
        private static Archivo INSTANCE = new Archivo();
        private List<Linea> lineas;

        private Archivo() { }

        public static Archivo obtenerInstancia()
        {
            return INSTANCE;
        }

        public void agregarLinea(Linea linea)
        {
            if (lineas == null)
            {
                lineas = new List<Linea>();
            }

            lineas.Add(linea);
        }

        public Linea obtenerLinea(int nroLinea)
        {
            //return (lineaEstaDisponible(nroLinea) ? lineas.ElementAt(nroLinea - 1) : null);
            Linea lineaReturn = null;
            if (nroLinea > lineas.Count)
            {
                lineaReturn = new Linea();
                lineaReturn.numeroLinea = nroLinea;
                lineaReturn.contenido = "@EOF@";
            }
            else
                lineaReturn = lineas[nroLinea - 1];

            return lineaReturn;
        }

        public int obtenerCantidadLineas()
        {
            return (lineas == null) ? 0 : lineas.Count;
        }
        public Boolean lineaEstaDisponible(int numeroLinea)
        {
            return ((numeroLinea - 1) >= 0 && (numeroLinea - 1) <= lineas.Count);
        }

        public void limpiarLineas()
        {
            lineas.Clear();
        }

    }
}
