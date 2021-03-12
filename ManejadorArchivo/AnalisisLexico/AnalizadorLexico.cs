using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManejadorArchivo.Transversal;

namespace ManejadorArchivo.AnalisisLexico
{
    public class AnalizadorLexico
    {
        private int numeroLineaActual = 0;
        private String contenidoLineaActual;
        private int puntero;
        private String caracterActual;


        public AnalizadorLexico()
        {
            cargarNuevaLinea();
        }
        private void devolverPuntero()
        {
            puntero = puntero - 1;
        }

        private void cargarNuevaLinea()
        {
            if (contenidoLineaActual != "@EOF@")
            {
                numeroLineaActual = numeroLineaActual + 1;
                puntero = 1;
                Linea lineaTmp = Archivo.obtenerInstancia().obtenerLinea(numeroLineaActual);
                contenidoLineaActual = (lineaTmp == null) ? "@EOF@" : lineaTmp.contenido;
            }
        }

        private void leerSiguienteCaracter()
        {
            if ("@EOF@".Equals(contenidoLineaActual))
            {
                caracterActual = contenidoLineaActual;
            }
            else if (puntero > contenidoLineaActual.Length)
            {
                caracterActual = "@FL@";
                puntero++;
            }
            else
            {
                caracterActual = contenidoLineaActual.Substring((puntero - 1), 1);
                puntero++;
            }
        }

        public ComponenteLexico analizar()
        {
            int estadoActual = 0;
            bool continuarAnalisis = true;
            String lexema = "";
            ComponenteLexico componente = null;


            while (continuarAnalisis)
            {
                switch (estadoActual)
                {
                    #region caso 0
                    case 0:
                        leerSiguienteCaracter();
                        // Devorado de espacios en blanco
                        while (" ".Equals(caracterActual))
                        {
                            leerSiguienteCaracter();
                        }
                        if (char.IsLetter(caracterActual.ToCharArray()[0]) | "$".Equals(caracterActual) | "_".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 4;
                        }
                        else if (char.IsDigit(caracterActual.ToArray()[0]))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 1;
                        }
                        else if ("+".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 5;
                        }
                        else if ("-".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 6;
                        }
                        else if ("*".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 7;
                        }
                        else if ("/".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 8;
                        }
                        else if ("%".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 9;
                        }
                        else if ("(".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 10;
                        }
                        else if (")".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 11;
                        }
                        else if ("@EOF@".Equals(caracterActual))
                        {
                            estadoActual = 12;
                        }
                        else if ("=".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 19;
                        }
                        else if ("<".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 20;
                        }
                        else if (">".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 21;
                        }
                        else if (":".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 22;
                        }
                        else if ("!".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 30;
                        }
                        else if ("@FL@".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 13;
                        }
                        else
                        {
                            estadoActual = 18;
                        }
                        break;
                    #endregion

                    case 1:
                        leerSiguienteCaracter();
                        if (char.IsDigit(caracterActual.ToCharArray()[0]))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 1;
                        }
                        else if (",".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 2;
                        }
                        else // Otro caracter
                        {
                            estadoActual = 14;
                        }
                        break;
                    case 2:
                        leerSiguienteCaracter();
                        if (char.IsDigit(caracterActual.ToCharArray()[0]))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 3;
                        }
                        else // Otro caracter
                        {
                            estadoActual = 17;
                        }
                        break;
                    case 3:
                        leerSiguienteCaracter();
                        if (char.IsDigit(caracterActual.ToCharArray()[0]))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 3;
                        }
                        else // Otro caracter
                        {
                            estadoActual = 15;
                        }

                        break;
                    case 4:
                        leerSiguienteCaracter();
                        if (char.IsLetter(caracterActual.ToCharArray()[0]) || char.IsDigit(caracterActual.ToCharArray()[0])
                            || "$".Equals(caracterActual) || "_".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 4;
                        }
                        else // Otro caracter
                        {
                            estadoActual = 16;
                        }
                        break;

                    case 5:
                        continuarAnalisis = false;
                        componente = formarComponente(lexema, "SUMA");
                        componente.TipoComponente = Tipo.COMPONENTE_LEXICO;
                        TablaMaestra.obtenerInstancia().sincronizarElemento(componente);
                        break;
                    case 6:
                        continuarAnalisis = false;
                        componente = formarComponente(lexema, "RESTA");
                        componente.TipoComponente = Tipo.COMPONENTE_LEXICO;
                        TablaMaestra.obtenerInstancia().sincronizarElemento(componente);
                        break;

                    case 7:
                        continuarAnalisis = false;
                        componente = formarComponente(lexema, "MULTIPLICACION");
                        componente.TipoComponente = Tipo.COMPONENTE_LEXICO;
                        TablaMaestra.obtenerInstancia().sincronizarElemento(componente);
                        break;
                    case 8:
                        leerSiguienteCaracter();
                        if ("*".Equals(caracterActual))
                        {
                            estadoActual = 34;
                        }
                        else if ("/".Equals(caracterActual))
                        {
                            estadoActual = 36;
                        }
                        else
                        {
                            estadoActual = 33;
                        }
                        break;
                    case 9:
                        continuarAnalisis = false;
                        componente = formarComponente(lexema, "MODULO");
                        componente.TipoComponente = Tipo.COMPONENTE_LEXICO;
                        TablaMaestra.obtenerInstancia().sincronizarElemento(componente);
                        break;
                    case 10:
                        continuarAnalisis = false;
                        componente = formarComponente(lexema, "PARENTESIS ABRE");
                        componente.TipoComponente = Tipo.COMPONENTE_LEXICO;
                        TablaMaestra.obtenerInstancia().sincronizarElemento(componente);
                        break;
                    case 11:
                        continuarAnalisis = false;
                        componente = formarComponente(lexema, "PARENTESIS CIERRA");
                        componente.TipoComponente = Tipo.COMPONENTE_LEXICO;
                        TablaMaestra.obtenerInstancia().sincronizarElemento(componente);
                        break;
                    case 12:
                        continuarAnalisis = false;
                        //lexema = caracterActual;
                        componente = formarComponente(lexema, "FIN DE ARCHIVO");
                        TablaMaestra.obtenerInstancia().sincronizarElemento(componente);
                        break;
                    case 13:
                        // retorna salto de linea
                        lexema = "";
                        cargarNuevaLinea();
                        estadoActual = 0;
                        break;

                    case 14:
                        devolverPuntero();
                        continuarAnalisis = false;
                        componente = formarComponente(lexema, "NUMERO ENTERO");
                        componente.TipoComponente = Tipo.LITERAL;
                        TablaMaestra.obtenerInstancia().sincronizarElemento(componente);
                        break;

                    case 15:
                        devolverPuntero();
                        continuarAnalisis = false;
                        componente = formarComponente(lexema, "NUMERO DECIMAL");
                        componente.TipoComponente = Tipo.LITERAL;
                        TablaMaestra.obtenerInstancia().sincronizarElemento(componente);
                        break;

                    case 16:
                        devolverPuntero();
                        continuarAnalisis = false;
                        componente = formarComponente(lexema, "IDENTIFICADOR");
                        componente.TipoComponente = Tipo.COMPONENTE_LEXICO;
                        TablaMaestra.obtenerInstancia().sincronizarElemento(componente);
                        break;

                    case 17: // CONTROLA ERROR DE NUMERO DECIMAL NO VALIDO\
                        devolverPuntero();
                        continuarAnalisis = false;
                        String causa = "Se esperaba un número y se recibió: " + caracterActual + ".";
                        String solucion = "Asegúrese de tener un número decimal válido.";
                        ManejadorErrores.obtenerInstancia().agregar(formarError(lexema, causa, solucion, "LEXICO"));
                        componente = formarComponente(lexema + '0', "NUMERO DECIMAL");
                        componente.TipoComponente = Tipo.DUMMY;
                        TablaMaestra.obtenerInstancia().sincronizarElemento(componente);
                        break;

                    case 18:
                        String causaStopper = "Se esperaba un simbolo válido " + caracterActual + ".";
                        String solucionStopper = "Asegúrese de utilizar un simbolo válido.";
                        ManejadorErrores.obtenerInstancia().agregar(formarError(lexema, causaStopper, solucionStopper, "LEXICO"));
                        //throw new Exception("Se ha presentado un problema que impide continuar con el analisis");
                        estadoActual = 12;
                        break;
                    case 19:
                        continuarAnalisis = false;
                        componente = formarComponente(lexema, "IGUAL QUE");
                        componente.TipoComponente = Tipo.COMPONENTE_LEXICO;
                        TablaMaestra.obtenerInstancia().sincronizarElemento(componente);
                        break;
                    case 20:
                        leerSiguienteCaracter();
                        if (">".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 23;
                        }
                        else if ("=".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 24;
                        }
                        else
                        {
                            estadoActual = 25;
                        }
                        break;
                    case 21:
                        leerSiguienteCaracter();
                        if ("=".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 26;
                        }
                        else
                        {
                            estadoActual = 27;
                        }
                        break;
                    case 22:
                        leerSiguienteCaracter();
                        if ("=".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 28;
                        }
                        else
                        {
                            estadoActual = 29;
                        }
                        break;
                    case 23:
                        continuarAnalisis = false;
                        componente = formarComponente(lexema, "DIFERENTE QUE");
                        componente.TipoComponente = Tipo.COMPONENTE_LEXICO;
                        TablaMaestra.obtenerInstancia().sincronizarElemento(componente);
                        break;
                    case 24:
                        continuarAnalisis = false;
                        componente = formarComponente(lexema, "MENOR O IGUAL QUE");
                        componente.TipoComponente = Tipo.COMPONENTE_LEXICO;
                        TablaMaestra.obtenerInstancia().sincronizarElemento(componente);
                        break;
                    case 25:
                        continuarAnalisis = false;
                        componente = formarComponente(lexema, "MENOR QUE");
                        componente.TipoComponente = Tipo.COMPONENTE_LEXICO;
                        TablaMaestra.obtenerInstancia().sincronizarElemento(componente);
                        break;
                    case 26:
                        continuarAnalisis = false;
                        componente = formarComponente(lexema, "MAYOR O IGIAL QUE");
                        componente.TipoComponente = Tipo.COMPONENTE_LEXICO;
                        TablaMaestra.obtenerInstancia().sincronizarElemento(componente);
                        break;
                    case 27:
                        continuarAnalisis = false;
                        componente = formarComponente(lexema, "MAYOR QUE");
                        componente.TipoComponente = Tipo.COMPONENTE_LEXICO;
                        TablaMaestra.obtenerInstancia().sincronizarElemento(componente);
                        break;
                    case 28:
                        continuarAnalisis = false;
                        componente = formarComponente(lexema, "ASIGNACION");
                        componente.TipoComponente = Tipo.COMPONENTE_LEXICO;
                        TablaMaestra.obtenerInstancia().sincronizarElemento(componente);
                        break;
                    case 29:// ERROR ASIGNACION NO VALIDA
                        devolverPuntero();
                        continuarAnalisis = false;
                        String causa29 = "Se esperaba un igual y se recibió: " + caracterActual + ",";
                        String solucion29 = "Asegúrese de tener un igual en la asignación.";
                        ManejadorErrores.obtenerInstancia().agregar(formarError(lexema, causa29, solucion29, "LEXICO"));
                        componente = formarComponente(lexema + '=', "ASIGNACION");
                        componente.TipoComponente = Tipo.DUMMY;
                        //componente.EsDummy = true;
                        TablaMaestra.obtenerInstancia().sincronizarElemento(componente);
                        break;
                    case 30:
                        leerSiguienteCaracter();
                        if ("=".Equals(caracterActual))
                        {
                            lexema = lexema + caracterActual;
                            estadoActual = 31;
                        }
                        else
                        {
                            estadoActual = 32;
                        }
                        break;
                    case 31:
                        continuarAnalisis = false;
                        componente = formarComponente(lexema, "DIFERENTE QUE");
                        componente.TipoComponente = Tipo.COMPONENTE_LEXICO;
                        TablaMaestra.obtenerInstancia().sincronizarElemento(componente);
                        break;
                    case 32: // ERROR DIFERENTE QUE NO VALIDA
                        devolverPuntero();
                        continuarAnalisis = false;
                        String causa32 = "Se esperaba un igual y se recibió: " + caracterActual + ",";
                        String solucion32 = "Asegúrese de tener un igual en diferente que.";
                        ManejadorErrores.obtenerInstancia().agregar(formarError(lexema, causa32, solucion32, "LEXICO"));
                        componente = formarComponente(lexema + '=', "DIFERENTE QUE");
                        //componente.EsDummy = true;
                        TablaMaestra.obtenerInstancia().sincronizarElemento(componente);
                        break;
                    case 33:
                        continuarAnalisis = false;
                        componente = formarComponente(lexema, "DIVISION");
                        componente.TipoComponente = Tipo.COMPONENTE_LEXICO;
                        TablaMaestra.obtenerInstancia().sincronizarElemento(componente);
                        break;

                    case 34:
                        leerSiguienteCaracter();
                        if (caracterActual == "*")
                        {
                            estadoActual = 35;
                        }
                        else if ("@FL@".Equals(caracterActual))
                        {
                            estadoActual = 37;
                        }
                        else if ("@EOF@".Equals(caracterActual))
                        {
                            estadoActual = 38;
                        }
                        else
                        {
                            estadoActual = 34;
                        }
                        break;

                    case 35:
                        leerSiguienteCaracter();
                        if ("*".Equals(caracterActual))
                        {
                            estadoActual = 35;
                        }
                        else if ("/".Equals(caracterActual))
                        {
                            caracterActual = "";
                            lexema = "";
                            estadoActual = 0;
                        }
                        else
                        {
                            estadoActual = 34;
                        }

                        break;
                    case 36:
                        leerSiguienteCaracter();
                        if (caracterActual != "@FL@")
                        {
                            estadoActual = 36;
                        }
                        else
                        {
                            estadoActual = 13;
                        }

                        break;
                    case 37:   // FIN DE LINEA
                        cargarNuevaLinea();
                        estadoActual = 34;

                        break;
                    case 38: // ERROR COMENTARIO NO VALIDO
                        String causa38 = "Se esperaba un cierre de comentario";
                        String solucion38 = "Asegúrese de cerrar los comentarios.";
                        ManejadorErrores.obtenerInstancia().agregar(formarError(lexema, causa38, solucion38, "LEXICO"));
                        componente = formarComponente(lexema + '*' + '/', " ");
                        //componente.EsDummy = true;
                        TablaMaestra.obtenerInstancia().sincronizarElemento(componente);

                        estadoActual = 12;
                        break;


                }
            }

            return componente;
        }

        private ComponenteLexico formarComponente(String lexema, String categoria)
        {
            ComponenteLexico componente = new ComponenteLexico();
            componente.Categoria = categoria;
            componente.Lexema = lexema;
            componente.NumeroLinea = numeroLineaActual;
            componente.PosicionInicial = puntero - lexema.Length;
            componente.PosicionFinal = puntero - 1;

            return componente;
        }

        private Error formarError(String lexema, String causa, String solucion, String tipo)
        {
            Error error = new Error();
            error.Lexema = lexema;
            error.Causa = causa;
            error.Solucion = solucion;
            error.Tipo = tipo;
            error.NumeroLinea = numeroLineaActual;
            error.PosicionInicial = puntero - lexema.Length;
            error.PosicionFinal = puntero - 1;

            return error;
        }

    }
}

