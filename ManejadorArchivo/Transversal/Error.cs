using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorArchivo.Transversal
{
    public class Error
    {
        public String Lexema { get; set; }

        public String Causa { get; set; }

        public String Solucion { get; set; }

        public String Tipo { get; set; }

        public int NumeroLinea { get; set; }

        public int PosicionInicial { get; set; }

        public int PosicionFinal { get; set; }

    }
}
