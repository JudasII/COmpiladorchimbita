using ManejadorArchivo.AnalisisLexico;
using ManejadorArchivo.AnalisisSintactico;
using ManejadorArchivo.Transversal;
using System;
using System.IO;
using System.Windows.Forms;

namespace ManejadorArchivo
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            gbArchivo.Visible = false;
            gbConsola.Visible = false;
            rtbArchivoConsola.Visible = false;
        }

        private void rbArchivo_CheckedChanged(object sender, EventArgs e)
        {
            gbArchivo.Visible = true;
            gbConsola.Visible = false;
            txtConsola.Text = "";
            rtbArchivoConsola.Text = "";
            rtbArchivoConsola.Visible = true;
        }

        private void rbConsola_CheckedChanged(object sender, EventArgs e)
        {
            gbArchivo.Visible = false;
            gbConsola.Visible = true;
            txtConsola.Text = "";
            txtRuta.Clear();
            rtbArchivoConsola.Text = "";
            rtbArchivoConsola.Visible = true;
            txtConsola.Focus();
        }

        private void btnCargarDocumento_Click(object sender, EventArgs e)
        {
            rtbArchivoConsola.Text = "";

            OpenFileDialog abrirBuscador = new OpenFileDialog();
            abrirBuscador.DefaultExt = "*.txt";
            abrirBuscador.Filter = "Archivo de texto |*.txt";
            abrirBuscador.Title = "Seleccione el archivo de texto";
            //ruta = abrirBuscador.FileName;

            if (abrirBuscador.ShowDialog() == DialogResult.OK)
            {
                //if (!abrirBuscador.FileName.Equals(""))

                Archivo archivo = Archivo.obtenerInstancia();
                //archivo.limpiarLineas();


                string ruta = abrirBuscador.FileName;
                txtRuta.Text = ruta;

                StreamReader sr = new StreamReader(ruta);
                string lineaActual = "";
                string leerLineaConcatenado = "";

                int n = 1;
                Linea line;

                string[] arreglo = sr.ReadToEnd().Split('\n'); // salto de linea \n

                foreach (string linea in arreglo)
                {
                    leerLineaConcatenado += linea;
                }
                arreglo = leerLineaConcatenado.Split('\r'); // retocedes carro \r

                foreach (string linea in arreglo)
                {
                    line = new Linea();
                    line.contenido = linea;
                    line.numeroLinea = n;
                    archivo.agregarLinea(line);
                    lineaActual = lineaActual + "Linea" + n + "-->" + line.contenido + Environment.NewLine;
                    n++;
                }

                rtbArchivoConsola.Text = lineaActual;
                sr.Close();


            }

        }

        private void btnCargarTexto_Click(object sender, EventArgs e)
        {
            if (txtConsola.Text == "")
            {
                MessageBox.Show("Ingrese Texto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtbArchivoConsola.Text = "";
                txtConsola.Focus();
            }

            Archivo archivo = Archivo.obtenerInstancia();
            //archivo.limpiarLineas();

            string[] leerLinea = txtConsola.Text.Split('\n'); // \n = salta nueva linea
            String cadena = "";
            String lineaActual = "";

            foreach (String var in leerLinea)
            {
                lineaActual += var;
            }
            leerLinea = null;
            leerLinea = lineaActual.Split('\r');  // \r = Retorno de carro 
            Linea line;

            int i = 1;
            foreach (string linea in leerLinea)
            {
                line = new Linea();
                line.contenido = linea;
                line.numeroLinea = i;
                archivo.agregarLinea(line);
                cadena = cadena + "Linea" + i + "-->" + line.contenido + Environment.NewLine;
                i++;

            }
            //cargarSalida(archivo);
            rtbArchivoConsola.Text = cadena;


        }

        private void cargarSalida(Archivo archivo)
        {
            string contenido = "";
            int i = 1;
            while (archivo.obtenerLinea(i).contenido != "@EOF@")
            {
                contenido = contenido + "Linea " + i + " --> " + archivo.obtenerLinea(i).contenido + Environment.NewLine;
                i = i + 1;
            }
            rtbArchivoConsola.Text = contenido;
        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            rtbArchivoConsola.Clear();
            txtRuta.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            rtbArchivoConsola.Clear();
            txtConsola.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rtbArchivoConsola_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablaErrores.DataSource = null;
            tablaSimbolos.DataSource = null;
            tablaReservadas.DataSource = null;
            tablaLiterales.DataSource = null;
            tablaDummies.DataSource = null;

            AnalizadorSintactico ana = new AnalizadorSintactico();
            ana.analizar();

            //AnalizadorLexico anaLex = new AnalizadorLexico();
            //ComponenteLexico componente = anaLex.analizar();

            //while (!componente.Categoria.Equals("FIN DE ARCHIVO"))
            //{
            //    /*MessageBox.Show("LEXEMA: " + componente.Lexema + ", CATEGORIA: " + componente.Categoria);*/
            //    componente = anaLex.analizar();
            //}

            tablaErrores.DataSource = ManejadorErrores.obtenerInstancia().ObtenerTodo();
            tablaSimbolos.DataSource = TablaSimbolos.obtenerInstancia().ObtenerTodo();
            tablaReservadas.DataSource = TablaPalabrasReservadas.obtenerInstancia().ObtenerTodo();
            tablaLiterales.DataSource = TablaLiterales.obtenerInstancia().ObtenerTodo();
            tablaDummies.DataSource = TablaDummys.obtenerInstancia().ObtenerTodo();



        }
    }
}
