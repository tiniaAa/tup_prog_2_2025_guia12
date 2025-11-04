namespace Ejercicio1
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
            label1 = new Label();
            tbDNI = new TextBox();
            btnTicket = new Button();
            rdbtDenuncia = new RadioButton();
            rdbtNuevoCliente = new RadioButton();
            tbDenuncia = new TextBox();
            Turnos = new Label();
            lbTurnos = new ListBox();
            btnAtenderDenuncias = new Button();
            btnAtenderCliente = new Button();
            btnImportar = new Button();
            btnExportar = new Button();
            cbTipo = new ComboBox();
            groupBox1 = new GroupBox();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "DNI";
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(80, 4);
            tbDNI.Margin = new Padding(3, 2, 3, 2);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(110, 23);
            tbDNI.TabIndex = 1;
            // 
            // btnTicket
            // 
            btnTicket.Location = new Point(318, 31);
            btnTicket.Margin = new Padding(3, 2, 3, 2);
            btnTicket.Name = "btnTicket";
            btnTicket.Size = new Size(82, 102);
            btnTicket.TabIndex = 2;
            btnTicket.Text = "Ticket";
            btnTicket.UseVisualStyleBackColor = true;
            btnTicket.Click += btnTicket_Click;
            // 
            // rdbtDenuncia
            // 
            rdbtDenuncia.AutoSize = true;
            rdbtDenuncia.Location = new Point(5, 20);
            rdbtDenuncia.Margin = new Padding(3, 2, 3, 2);
            rdbtDenuncia.Name = "rdbtDenuncia";
            rdbtDenuncia.Size = new Size(75, 19);
            rdbtDenuncia.TabIndex = 3;
            rdbtDenuncia.TabStop = true;
            rdbtDenuncia.Text = "Denuncia";
            rdbtDenuncia.UseVisualStyleBackColor = true;
            // 
            // rdbtNuevoCliente
            // 
            rdbtNuevoCliente.AutoSize = true;
            rdbtNuevoCliente.Location = new Point(5, 61);
            rdbtNuevoCliente.Margin = new Padding(3, 2, 3, 2);
            rdbtNuevoCliente.Name = "rdbtNuevoCliente";
            rdbtNuevoCliente.Size = new Size(98, 19);
            rdbtNuevoCliente.TabIndex = 4;
            rdbtNuevoCliente.TabStop = true;
            rdbtNuevoCliente.Text = "Nuevo cliente";
            rdbtNuevoCliente.UseVisualStyleBackColor = true;
            // 
            // tbDenuncia
            // 
            tbDenuncia.Location = new Point(145, 17);
            tbDenuncia.Margin = new Padding(3, 2, 3, 2);
            tbDenuncia.Name = "tbDenuncia";
            tbDenuncia.Size = new Size(110, 23);
            tbDenuncia.TabIndex = 5;
            // 
            // Turnos
            // 
            Turnos.AutoSize = true;
            Turnos.Location = new Point(33, 148);
            Turnos.Name = "Turnos";
            Turnos.Size = new Size(44, 15);
            Turnos.TabIndex = 6;
            Turnos.Text = "Turnos";
            // 
            // lbTurnos
            // 
            lbTurnos.FormattingEnabled = true;
            lbTurnos.ItemHeight = 15;
            lbTurnos.Location = new Point(33, 165);
            lbTurnos.Margin = new Padding(3, 2, 3, 2);
            lbTurnos.Name = "lbTurnos";
            lbTurnos.Size = new Size(204, 79);
            lbTurnos.TabIndex = 7;
            // 
            // btnAtenderDenuncias
            // 
            btnAtenderDenuncias.Location = new Point(38, 248);
            btnAtenderDenuncias.Margin = new Padding(3, 2, 3, 2);
            btnAtenderDenuncias.Name = "btnAtenderDenuncias";
            btnAtenderDenuncias.Size = new Size(80, 37);
            btnAtenderDenuncias.TabIndex = 8;
            btnAtenderDenuncias.Text = "Atender Denuncias";
            btnAtenderDenuncias.UseVisualStyleBackColor = true;
            btnAtenderDenuncias.Click += btnAtenderDenuncias_Click;
            // 
            // btnAtenderCliente
            // 
            btnAtenderCliente.Location = new Point(147, 248);
            btnAtenderCliente.Margin = new Padding(3, 2, 3, 2);
            btnAtenderCliente.Name = "btnAtenderCliente";
            btnAtenderCliente.Size = new Size(80, 37);
            btnAtenderCliente.TabIndex = 9;
            btnAtenderCliente.Text = "Atender nuevos clientes";
            btnAtenderCliente.UseVisualStyleBackColor = true;
            btnAtenderCliente.Click += btnAtenderCliente_Click;
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(242, 211);
            btnImportar.Margin = new Padding(3, 2, 3, 2);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(134, 32);
            btnImportar.TabIndex = 10;
            btnImportar.Text = "Importar vehiculos ";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(242, 165);
            btnExportar.Margin = new Padding(3, 2, 3, 2);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(134, 32);
            btnExportar.TabIndex = 11;
            btnExportar.Text = "Exportar Tickets";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "1- Auto ", "2-Moto ", "3- Equipo de trabajo ", "4- Bicicleta" });
            cbTipo.Location = new Point(145, 58);
            cbTipo.Margin = new Padding(3, 2, 3, 2);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(57, 23);
            cbTipo.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbtDenuncia);
            groupBox1.Controls.Add(cbTipo);
            groupBox1.Controls.Add(rdbtNuevoCliente);
            groupBox1.Controls.Add(tbDenuncia);
            groupBox1.Location = new Point(10, 37);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(286, 96);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del cliente";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 296);
            Controls.Add(groupBox1);
            Controls.Add(btnExportar);
            Controls.Add(btnImportar);
            Controls.Add(btnAtenderCliente);
            Controls.Add(btnAtenderDenuncias);
            Controls.Add(lbTurnos);
            Controls.Add(Turnos);
            Controls.Add(btnTicket);
            Controls.Add(tbDNI);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbDNI;
        private Button btnTicket;
        private RadioButton rdbtDenuncia;
        private RadioButton rdbtNuevoCliente;
        private TextBox tbDenuncia;
        private Label Turnos;
        private ListBox lbTurnos;
        private Button btnAtenderDenuncias;
        private Button btnAtenderCliente;
        private Button btnImportar;
        private Button btnExportar;
        private ComboBox cbTipo;
        private GroupBox groupBox1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}
