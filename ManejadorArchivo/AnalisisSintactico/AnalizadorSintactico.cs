using ManejadorArchivo.AnalisisLexico;
using ManejadorArchivo.Transversal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejadorArchivo.AnalisisSintactico
{
    public class AnalizadorSintactico
    {

        private ComponenteLexico componente;
        private AnalizadorLexico analizadorLexico = new AnalizadorLexico();

        public void analizar()
        {
            try
            {
                componente = analizadorLexico.analizar();
                operacion();

                if (ManejadorErrores.obtenerInstancia().hayErrores())
                {
                    MessageBox.Show("El programa esta mal escrito. Verifique la tabla de errores presentados");
                }
                else
                {
                    if (componente.Categoria.Equals("FIN DE ARCHIVO"))
                    {
                        MessageBox.Show("El programa esta bien escrito.");
                    }
                    else
                    {
                        MessageBox.Show("El programa esta bien escrito. Faltaron componentes por evaluar...");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }


        // <operacion> := <multDiv><operPrima>
        private void operacion()
        {
            multiplicacionDivision();
            operacionPrima();
        }

        // <multDiv> := <opeMultDiv><resto><multDiv> | <resto>
        private void multiplicacionDivision()
        {
            resto();
            multiplicacionDivisionPrima();

        }

        // <operPrima> := "SUMA"<operacion> | "RESTA"<operacion> | EPSILON
        private void operacionPrima()
        {
            if (componente.Categoria.Equals("SUMA"))
            {
                pedirComponente("SUMA");
                operacion();
            }
            else if (componente.Categoria.Equals("RESTA"))
            {
                pedirComponente("RESTA");
                operacion();
            }
        }

        // <resto> := "NUMERO ENTERO" | "NUMERO DECIMAL" | "PARENTESIS ABRE"<operacion> "PARENTESIS CIERRA"
        private void resto()
        {
            if (componente.Categoria.Equals("NUMERO ENTERO"))
            {
                pedirComponente("NUMERO ENTERO");
            }
            else if (componente.Categoria.Equals("NUMERO DECIMAL"))
            {
                pedirComponente("NUMERO DECIMAL");
            }
            else if (componente.Categoria.Equals("PARENTESIS ABRE"))
            {
                pedirComponente("PARENTESIS ABRE");
                operacion();
                pedirComponente("PARENTESIS CIERRA");
            }
            else
            {
                // GESTIONAR ERROR SINTACTICO
                String causa = "Se esperaba NUMERO ENTERO, NUMERO DECIMAL o ABRE PARECTESIS y se recibió: " + componente.Categoria + ".";
                String solucion = "Garantice que la sintaxis del programa esté correcto. No es posible continuar con el análisis";
                ManejadorErrores.obtenerInstancia().agregar(formarError(componente.Categoria, causa, solucion, "SINTACTICO"));

                throw new Exception("Se ha presentado un problema que impide continuar con el analisis sintactico");
            }

        }

        // <operPrima> := "MULTIPLICACION"<multDiv> | "DIVISION"<multDiv> | EPSILON
        private void multiplicacionDivisionPrima()
        {
            if (componente.Categoria.Equals("MULTIPLICACION"))
            {
                pedirComponente("MULTIPLICACION");
                multiplicacionDivision();
            }
            else if (componente.Categoria.Equals("DIVISION"))
            {
                pedirComponente("DIVISION");
                multiplicacionDivision();
            }

        }

        private void pedirComponente(String categoriaEsperada)
        {
            if (categoriaEsperada.Equals(componente.Categoria))
            {
                componente = analizadorLexico.analizar();
            }
            else
            {
                // gestionar error sintactico
                String causa = "Se esperaba un " + categoriaEsperada + " y se recibió: " + componente.Categoria + ".";
                String solucion = "Garantice que la sintaxis del programa esté correcto.";
                ManejadorErrores.obtenerInstancia().agregar(formarError(componente.Categoria, causa, solucion, "SINTACTICO"));
            }
        }

        private Error formarError(String lexema, String causa, String solucion, String tipo)
        {
            Error error = new Error();
            error.Lexema = lexema;
            error.Causa = causa;
            error.Solucion = solucion;
            error.Tipo = tipo;
            error.NumeroLinea = componente.NumeroLinea;
            error.PosicionInicial = componente.PosicionInicial;
            error.PosicionFinal = componente.PosicionFinal;

            return error;
        }



    }
}
