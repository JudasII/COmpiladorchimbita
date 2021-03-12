using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorArchivo.AnalisisLexico
{
    public class ComponenteLexico
    {
        public String Lexema { get; set; }

        public String Categoria { get; set; }

        public Tipo TipoComponente { get; set; }
        public int NumeroLinea { get; set; }

        public int PosicionInicial { get; set; }

        public int PosicionFinal { get; set; }

        public ComponenteLexico()
        {
            TipoComponente = Tipo.COMPONENTE_LEXICO;
        }

        private ComponenteLexico(String Lexema, String Categoria, int NumeroLinea, int PosicionInicial, int PosicionFinal)
        {
            TipoComponente = Tipo.COMPONENTE_LEXICO;
            this.NumeroLinea = NumeroLinea;
            this.PosicionInicial = PosicionInicial;
            this.PosicionFinal = PosicionFinal;
            this.Lexema = Lexema;
            this.Categoria = Categoria;
        }


        public static ComponenteLexico Crear(String Lexema, String Categoria, int NumeroLinea, int PosicionInicial, int PosicionFinal)
        {
            return new ComponenteLexico(Lexema, Categoria, NumeroLinea, PosicionInicial, PosicionFinal);
        }

        public static ComponenteLexico Crear(String Lexema, String Categoria)
        {
            return new ComponenteLexico(Lexema, Categoria, 0, 0, 0);
        }
    }
}
