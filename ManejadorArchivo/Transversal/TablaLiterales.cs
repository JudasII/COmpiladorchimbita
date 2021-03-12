using ManejadorArchivo.AnalisisLexico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorArchivo.Transversal
{
    public class TablaLiterales
    {
        private static TablaLiterales INSTANCE = new TablaLiterales();
        private Dictionary<String, List<ComponenteLexico>> tabla = new Dictionary<string, List<ComponenteLexico>>();
        private TablaLiterales() { }

        public static TablaLiterales obtenerInstancia()
        {
            return INSTANCE;
        }

        public void agregar(ComponenteLexico componente)
        {
            if (componente != null && componente.TipoComponente.Equals(Tipo.LITERAL))
            {
                if (tabla.ContainsKey(componente.Lexema))
                {
                    tabla[componente.Lexema].Add(componente);
                }
                else
                {
                    List<ComponenteLexico> lista = new List<ComponenteLexico>();
                    lista.Add(componente);
                    tabla.Add(componente.Lexema, lista);
                }
            }
        }

        public Dictionary<string, List<ComponenteLexico>> obtenerElementos()
        {
            return tabla;
        }
        public List<ComponenteLexico> ObtenerTodo()
        {
            return tabla.Values.SelectMany(simbolo => simbolo).ToList();
        }
    }
}
