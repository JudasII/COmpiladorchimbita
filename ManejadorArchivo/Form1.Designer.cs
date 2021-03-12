namespace ManejadorArchivo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbConsola = new System.Windows.Forms.GroupBox();
            this.txtConsola = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCargarTexto = new System.Windows.Forms.Button();
            this.gbArchivo = new System.Windows.Forms.GroupBox();
            this.btnLimpiar2 = new System.Windows.Forms.Button();
            this.btnCargarDocumento = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.rtbArchivoConsola = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rbArchivo = new System.Windows.Forms.RadioButton();
            this.rbConsola = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaErrores = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tablaSimbolos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tablaReservadas = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tablaLiterales = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tablaDummies = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.gbConsola.SuspendLayout();
            this.gbArchivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaErrores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaSimbolos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaReservadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLiterales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDummies)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConsola
            // 
            this.gbConsola.Controls.Add(this.txtConsola);
            this.gbConsola.Controls.Add(this.btnLimpiar);
            this.gbConsola.Controls.Add(this.btnCargarTexto);
            this.gbConsola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsola.Location = new System.Drawing.Point(23, 70);
            this.gbConsola.Name = "gbConsola";
            this.gbConsola.Size = new System.Drawing.Size(448, 177);
            this.gbConsola.TabIndex = 10;
            this.gbConsola.TabStop = false;
            this.gbConsola.Text = "Manual";
            // 
            // txtConsola
            // 
            this.txtConsola.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsola.Location = new System.Drawing.Point(32, 24);
            this.txtConsola.Multiline = true;
            this.txtConsola.Name = "txtConsola";
            this.txtConsola.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConsola.Size = new System.Drawing.Size(385, 100);
            this.txtConsola.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = true;
            this.btnLimpiar.Location = new System.Drawing.Point(227, 135);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 27);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCargarTexto
            // 
            this.btnCargarTexto.AutoSize = true;
            this.btnCargarTexto.Location = new System.Drawing.Point(146, 135);
            this.btnCargarTexto.Name = "btnCargarTexto";
            this.btnCargarTexto.Size = new System.Drawing.Size(75, 27);
            this.btnCargarTexto.TabIndex = 3;
            this.btnCargarTexto.Text = "Cargar";
            this.btnCargarTexto.UseVisualStyleBackColor = true;
            this.btnCargarTexto.Click += new System.EventHandler(this.btnCargarTexto_Click);
            // 
            // gbArchivo
            // 
            this.gbArchivo.Controls.Add(this.btnLimpiar2);
            this.gbArchivo.Controls.Add(this.btnCargarDocumento);
            this.gbArchivo.Controls.Add(this.txtRuta);
            this.gbArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbArchivo.Location = new System.Drawing.Point(48, 281);
            this.gbArchivo.Name = "gbArchivo";
            this.gbArchivo.Size = new System.Drawing.Size(375, 88);
            this.gbArchivo.TabIndex = 11;
            this.gbArchivo.TabStop = false;
            this.gbArchivo.Text = "Archivo";
            // 
            // btnLimpiar2
            // 
            this.btnLimpiar2.AutoSize = true;
            this.btnLimpiar2.Location = new System.Drawing.Point(197, 51);
            this.btnLimpiar2.Name = "btnLimpiar2";
            this.btnLimpiar2.Size = new System.Drawing.Size(75, 27);
            this.btnLimpiar2.TabIndex = 7;
            this.btnLimpiar2.Text = "Limpiar";
            this.btnLimpiar2.UseVisualStyleBackColor = true;
            this.btnLimpiar2.Click += new System.EventHandler(this.btnLimpiar2_Click);
            // 
            // btnCargarDocumento
            // 
            this.btnCargarDocumento.AutoSize = true;
            this.btnCargarDocumento.Location = new System.Drawing.Point(103, 51);
            this.btnCargarDocumento.Name = "btnCargarDocumento";
            this.btnCargarDocumento.Size = new System.Drawing.Size(75, 27);
            this.btnCargarDocumento.TabIndex = 6;
            this.btnCargarDocumento.Text = "Cargar";
            this.btnCargarDocumento.UseVisualStyleBackColor = true;
            this.btnCargarDocumento.Click += new System.EventHandler(this.btnCargarDocumento_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(19, 24);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(336, 23);
            this.txtRuta.TabIndex = 5;
            // 
            // rtbArchivoConsola
            // 
            this.rtbArchivoConsola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbArchivoConsola.Location = new System.Drawing.Point(48, 391);
            this.rtbArchivoConsola.Name = "rtbArchivoConsola";
            this.rtbArchivoConsola.ReadOnly = true;
            this.rtbArchivoConsola.Size = new System.Drawing.Size(378, 196);
            this.rtbArchivoConsola.TabIndex = 8;
            this.rtbArchivoConsola.Text = "";
            this.rtbArchivoConsola.TextChanged += new System.EventHandler(this.rtbArchivoConsola_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rbArchivo
            // 
            this.rbArchivo.AutoSize = true;
            this.rbArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbArchivo.Location = new System.Drawing.Point(221, 22);
            this.rbArchivo.Name = "rbArchivo";
            this.rbArchivo.Size = new System.Drawing.Size(75, 22);
            this.rbArchivo.TabIndex = 13;
            this.rbArchivo.Text = "Archivo";
            this.rbArchivo.UseVisualStyleBackColor = true;
            this.rbArchivo.CheckedChanged += new System.EventHandler(this.rbArchivo_CheckedChanged);
            // 
            // rbConsola
            // 
            this.rbConsola.AutoSize = true;
            this.rbConsola.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbConsola.Location = new System.Drawing.Point(335, 22);
            this.rbConsola.Name = "rbConsola";
            this.rbConsola.Size = new System.Drawing.Size(74, 22);
            this.rbConsola.TabIndex = 14;
            this.rbConsola.Text = "Manual";
            this.rbConsola.UseVisualStyleBackColor = true;
            this.rbConsola.CheckedChanged += new System.EventHandler(this.rbConsola_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tipo de Carga";
            // 
            // tablaErrores
            // 
            this.tablaErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaErrores.Location = new System.Drawing.Point(516, 31);
            this.tablaErrores.Name = "tablaErrores";
            this.tablaErrores.Size = new System.Drawing.Size(746, 94);
            this.tablaErrores.TabIndex = 16;
            this.tablaErrores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(859, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "ERRORES";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(844, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "COMPONENTES";
            // 
            // tablaSimbolos
            // 
            this.tablaSimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaSimbolos.Location = new System.Drawing.Point(516, 281);
            this.tablaSimbolos.Name = "tablaSimbolos";
            this.tablaSimbolos.Size = new System.Drawing.Size(746, 94);
            this.tablaSimbolos.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(820, 519);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "PALABRAS RESERVADAS";
            // 
            // tablaReservadas
            // 
            this.tablaReservadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaReservadas.Location = new System.Drawing.Point(516, 547);
            this.tablaReservadas.Name = "tablaReservadas";
            this.tablaReservadas.Size = new System.Drawing.Size(746, 94);
            this.tablaReservadas.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(857, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "LITERALES";
            // 
            // tablaLiterales
            // 
            this.tablaLiterales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaLiterales.Location = new System.Drawing.Point(516, 409);
            this.tablaLiterales.Name = "tablaLiterales";
            this.tablaLiterales.Size = new System.Drawing.Size(746, 94);
            this.tablaLiterales.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(862, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "DUMMYS";
            // 
            // tablaDummies
            // 
            this.tablaDummies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDummies.Location = new System.Drawing.Point(516, 155);
            this.tablaDummies.Name = "tablaDummies";
            this.tablaDummies.Size = new System.Drawing.Size(746, 94);
            this.tablaDummies.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 609);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 32);
            this.button1.TabIndex = 26;
            this.button1.Text = "ANALIZAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1301, 662);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tablaLiterales);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tablaDummies);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tablaReservadas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tablaSimbolos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tablaErrores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbArchivo);
            this.Controls.Add(this.rbConsola);
            this.Controls.Add(this.rtbArchivoConsola);
            this.Controls.Add(this.gbArchivo);
            this.Controls.Add(this.gbConsola);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Archivos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbConsola.ResumeLayout(false);
            this.gbConsola.PerformLayout();
            this.gbArchivo.ResumeLayout(false);
            this.gbArchivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaErrores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaSimbolos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaReservadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLiterales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDummies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConsola;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCargarTexto;
        private System.Windows.Forms.GroupBox gbArchivo;
        private System.Windows.Forms.Button btnLimpiar2;
        private System.Windows.Forms.Button btnCargarDocumento;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.RichTextBox rtbArchivoConsola;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton rbArchivo;
        private System.Windows.Forms.RadioButton rbConsola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsola;
        private System.Windows.Forms.DataGridView tablaErrores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tablaSimbolos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tablaReservadas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView tablaLiterales;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView tablaDummies;
        private System.Windows.Forms.Button button1;
    }
}

