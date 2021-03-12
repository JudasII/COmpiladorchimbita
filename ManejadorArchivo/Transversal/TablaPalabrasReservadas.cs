using ManejadorArchivo.AnalisisLexico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorArchivo.Transversal
{
    public class TablaPalabrasReservadas
    {
        private static TablaPalabrasReservadas INSTANCE = new TablaPalabrasReservadas();
        private Dictionary<String, ComponenteLexico> tabla = new Dictionary<string, ComponenteLexico>();
        private Dictionary<String, List<ComponenteLexico>> tablaPalabras = new Dictionary<string, List<ComponenteLexico>>();
        private TablaPalabrasReservadas()
        {
            tabla.Add("INICIO", ComponenteLexico.Crear("INICIO", "INICIO"));
            tabla.Add("FIN", ComponenteLexico.Crear("FIN", "FIN"));
            tabla.Add("ENTERO", ComponenteLexico.Crear("ENTERO", "ENTERO"));
            tabla.Add("DECIMAL", ComponenteLexico.Crear("DECIMAL", "DECIMAL"));
            tabla.Add("LOGICO", ComponenteLexico.Crear("LOGICO", "LOGICO"));
            tabla.Add("FECHA", ComponenteLexico.Crear("FECHA", "FECHA"));
            tabla.Add("TEXTO", ComponenteLexico.Crear("TEXTO", "TEXTO"));
            tabla.Add("CARACTER", ComponenteLexico.Crear("CARACTER", "CARACTER"));
            tabla.Add("ENTONCES", ComponenteLexico.Crear("ENTONCES", "ENTONCES"));
            tabla.Add("HACER", ComponenteLexico.Crear("HACER", "HACER"));
            tabla.Add("HASTA", ComponenteLexico.Crear("HASTA", "HASTA"));
        }

        public static TablaPalabrasReservadas obtenerInstancia()
        {
            return INSTANCE;
        }

        public void comprobarSiEsPalabraReservada(ComponenteLexico componente)
        {
            if (componente != null && tabla.ContainsKey(componente.Lexema))
            {
                componente.TipoComponente = Tipo.PALABRA_RESERVADA;
                componente.Categoria = tabla[componente.Lexema].Categoria;
            }
        }

        public void agregar(ComponenteLexico componente)
        {
            if (componente != null && componente.TipoComponente.Equals(Tipo.PALABRA_RESERVADA))
            {
                if (tablaPalabras.ContainsKey(componente.Lexema))
                {
                    tablaPalabras[componente.Lexema].Add(componente);
                }
                else
                {
                    List<ComponenteLexico> lista = new List<ComponenteLexico>();
                    lista.Add(componente);
                    tablaPalabras.Add(componente.Lexema, lista);
                }
            }
        }

        public Dictionary<string, List<ComponenteLexico>> obtenerElementos()
        {
            return tablaPalabras;
        }

        public List<ComponenteLexico> ObtenerTodo()
        {
            return tablaPalabras.Values.SelectMany(simbolo => simbolo).ToList();
        }
    }
}
