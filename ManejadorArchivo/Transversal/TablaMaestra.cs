using ManejadorArchivo.AnalisisLexico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorArchivo.Transversal
{
    public class TablaMaestra
    {
        private static TablaMaestra INSTANCE = new TablaMaestra();
        private TablaMaestra() { }

        public static TablaMaestra obtenerInstancia()
        {
            return INSTANCE;
        }

        public Dictionary<string, List<ComponenteLexico>> obtenerElementos(Tipo tipo)
        {
            switch (tipo)
            {
                case Tipo.COMPONENTE_LEXICO:
                    return TablaSimbolos.obtenerInstancia().obtenerElementos();
                case Tipo.DUMMY:
                    return TablaDummys.obtenerInstancia().obtenerElementos();
                case Tipo.PALABRA_RESERVADA:
                    return TablaPalabrasReservadas.obtenerInstancia().obtenerElementos();
                case Tipo.LITERAL:
                    return TablaLiterales.obtenerInstancia().obtenerElementos();
                default:
                    return null;
            }
        }

        public void sincronizarElemento(ComponenteLexico componente)
        {

            TablaPalabrasReservadas.obtenerInstancia().comprobarSiEsPalabraReservada(componente);
            switch (componente.TipoComponente)
            {
                case Tipo.COMPONENTE_LEXICO:
                    TablaSimbolos.obtenerInstancia().agregar(componente);
                    break;
                case Tipo.DUMMY:
                    TablaDummys.obtenerInstancia().agregar(componente);
                    break;
                case Tipo.PALABRA_RESERVADA:
                    TablaPalabrasReservadas.obtenerInstancia().agregar(componente);
                    break;
                case Tipo.LITERAL:
                    TablaLiterales.obtenerInstancia().agregar(componente);
                    break;
            }

        }

    }
}
