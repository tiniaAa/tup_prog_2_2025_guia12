namespace Ejercicio2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbxListaDeAutos = new ListBox();
            label1 = new Label();
            label2 = new Label();
            btnCrearCamion = new Button();
            btnCargar = new Button();
            btnDescargar = new Button();
            button4 = new Button();
            tbCapacidad = new TextBox();
            label3 = new Label();
            dtpFecha = new DateTimePicker();
            Cargas = new GroupBox();
            groupBox1 = new GroupBox();
            btnDescargarCamion = new Button();
            btnRecibirCamion = new Button();
            lbxListaDeRecibos = new ListBox();
            label4 = new Label();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            Cargas.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbxListaDeAutos
            // 
            lbxListaDeAutos.FormattingEnabled = true;
            lbxListaDeAutos.ItemHeight = 15;
            lbxListaDeAutos.Location = new Point(6, 62);
            lbxListaDeAutos.Name = "lbxListaDeAutos";
            lbxListaDeAutos.Size = new Size(173, 244);
            lbxListaDeAutos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 44);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 1;
            label1.Text = "Lista de autos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 62);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Capacidad";
            // 
            // btnCrearCamion
            // 
            btnCrearCamion.Location = new Point(185, 62);
            btnCrearCamion.Name = "btnCrearCamion";
            btnCrearCamion.Size = new Size(83, 49);
            btnCrearCamion.TabIndex = 3;
            btnCrearCamion.Text = "Crear camion";
            btnCrearCamion.UseVisualStyleBackColor = true;
            btnCrearCamion.Click += btnCrearCamion_Click;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(185, 125);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(83, 49);
            btnCargar.TabIndex = 4;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnDescargar
            // 
            btnDescargar.Location = new Point(185, 193);
            btnDescargar.Name = "btnDescargar";
            btnDescargar.Size = new Size(83, 49);
            btnDescargar.TabIndex = 5;
            btnDescargar.Text = "Descargar";
            btnDescargar.UseVisualStyleBackColor = true;
            btnDescargar.Click += btnDescargar_Click;
            // 
            // button4
            // 
            button4.Location = new Point(185, 257);
            button4.Name = "button4";
            button4.Size = new Size(83, 49);
            button4.TabIndex = 6;
            button4.Text = "Cerrar camion";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // tbCapacidad
            // 
            tbCapacidad.Location = new Point(307, 88);
            tbCapacidad.Name = "tbCapacidad";
            tbCapacidad.Size = new Size(100, 23);
            tbCapacidad.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(404, 6);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 8;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(124, 22);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 9;
            // 
            // Cargas
            // 
            Cargas.Controls.Add(btnCrearCamion);
            Cargas.Controls.Add(dtpFecha);
            Cargas.Controls.Add(tbCapacidad);
            Cargas.Controls.Add(btnDescargar);
            Cargas.Controls.Add(label2);
            Cargas.Controls.Add(btnCargar);
            Cargas.Controls.Add(label1);
            Cargas.Controls.Add(button4);
            Cargas.Controls.Add(lbxListaDeAutos);
            Cargas.Location = new Point(12, 12);
            Cargas.Name = "Cargas";
            Cargas.Size = new Size(427, 316);
            Cargas.TabIndex = 10;
            Cargas.TabStop = false;
            Cargas.Text = "Cargas";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDescargarCamion);
            groupBox1.Controls.Add(btnRecibirCamion);
            groupBox1.Controls.Add(lbxListaDeRecibos);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(445, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(304, 316);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Descargas";
            // 
            // btnDescargarCamion
            // 
            btnDescargarCamion.Location = new Point(209, 109);
            btnDescargarCamion.Name = "btnDescargarCamion";
            btnDescargarCamion.Size = new Size(89, 43);
            btnDescargarCamion.TabIndex = 3;
            btnDescargarCamion.Text = "Descargar";
            btnDescargarCamion.UseVisualStyleBackColor = true;
            btnDescargarCamion.Click += btnDescargarCamion_Click;
            // 
            // btnRecibirCamion
            // 
            btnRecibirCamion.Location = new Point(209, 62);
            btnRecibirCamion.Name = "btnRecibirCamion";
            btnRecibirCamion.Size = new Size(89, 43);
            btnRecibirCamion.TabIndex = 2;
            btnRecibirCamion.Text = "Recibir camion";
            btnRecibirCamion.UseVisualStyleBackColor = true;
            btnRecibirCamion.Click += btnRecibirCamion_Click;
            // 
            // lbxListaDeRecibos
            // 
            lbxListaDeRecibos.FormattingEnabled = true;
            lbxListaDeRecibos.ItemHeight = 15;
            lbxListaDeRecibos.Location = new Point(21, 62);
            lbxListaDeRecibos.Name = "lbxListaDeRecibos";
            lbxListaDeRecibos.Size = new Size(182, 199);
            lbxListaDeRecibos.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 30);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 0;
            label4.Text = "Lista de recibos ";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 338);
            Controls.Add(groupBox1);
            Controls.Add(Cargas);
            Controls.Add(label3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Cargas.ResumeLayout(false);
            Cargas.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbxListaDeAutos;
        private Label label1;
        private Label label2;
        private Button btnCrearCamion;
        private Button btnCargar;
        private Button btnDescargar;
        private Button button4;
        private TextBox tbCapacidad;
        private Label label3;
        private DateTimePicker dtpFecha;
        private GroupBox Cargas;
        private GroupBox groupBox1;
        private Button btnDescargarCamion;
        private Button btnRecibirCamion;
        private ListBox lbxListaDeRecibos;
        private Label label4;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
