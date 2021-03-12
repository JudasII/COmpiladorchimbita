using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManejadorArchivo.AnalisisLexico;

namespace ManejadorArchivo.Transversal
{
    public class TablaSimbolos
    {
        private static TablaSimbolos INSTANCE = new TablaSimbolos();
        private Dictionary<String, List<ComponenteLexico>> tabla = new Dictionary<string, List<ComponenteLexico>>();
        private TablaSimbolos() { }

        public static TablaSimbolos obtenerInstancia()
        {
            return INSTANCE;
        }

        public void agregar(ComponenteLexico componente)
        {
            if (componente != null && componente.TipoComponente.Equals(Tipo.COMPONENTE_LEXICO))
            {
                if (this.tabla.ContainsKey(componente.Lexema))
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
