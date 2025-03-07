namespace Reserva_de_Vuelos
{
    partial class Reservas
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
            this.codigo = new System.Windows.Forms.TextBox();
            this.destino = new System.Windows.Forms.TextBox();
            this.origen = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.registrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clumcodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clumOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clumDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clumFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservarBtn = new System.Windows.Forms.Button();
            this.cantidasAsientoNup = new System.Windows.Forms.NumericUpDown();
            this.DestinoCb = new System.Windows.Forms.ComboBox();
            this.origenCb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidasAsientoNup)).BeginInit();
            this.SuspendLayout();
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(36, 24);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(100, 20);
            this.codigo.TabIndex = 0;
            this.codigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // destino
            // 
            this.destino.Location = new System.Drawing.Point(36, 131);
            this.destino.Name = "destino";
            this.destino.Size = new System.Drawing.Size(100, 20);
            this.destino.TabIndex = 2;
            // 
            // origen
            // 
            this.origen.Location = new System.Drawing.Point(36, 76);
            this.origen.Name = "origen";
            this.origen.Size = new System.Drawing.Size(100, 20);
            this.origen.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(59, 258);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.registrar);
            this.panel1.Controls.Add(this.origen);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.codigo);
            this.panel1.Controls.Add(this.destino);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 409);
            this.panel1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 201);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(59, 334);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(100, 32);
            this.registrar.TabIndex = 5;
            this.registrar.Text = "Registrar";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.reservarBtn);
            this.panel2.Controls.Add(this.cantidasAsientoNup);
            this.panel2.Location = new System.Drawing.Point(268, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 251);
            this.panel2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clumcodigo,
            this.clumOrigen,
            this.clumDestino,
            this.clumFecha});
            this.dataGridView1.Location = new System.Drawing.Point(118, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 206);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // clumcodigo
            // 
            this.clumcodigo.HeaderText = "Codigo";
            this.clumcodigo.Name = "clumcodigo";
            // 
            // clumOrigen
            // 
            this.clumOrigen.HeaderText = "Origen";
            this.clumOrigen.Name = "clumOrigen";
            // 
            // clumDestino
            // 
            this.clumDestino.HeaderText = "Destino";
            this.clumDestino.Name = "clumDestino";
            // 
            // clumFecha
            // 
            this.clumFecha.HeaderText = "Fecha Salida";
            this.clumFecha.Name = "clumFecha";
            // 
            // reservarBtn
            // 
            this.reservarBtn.Location = new System.Drawing.Point(11, 111);
            this.reservarBtn.Name = "reservarBtn";
            this.reservarBtn.Size = new System.Drawing.Size(75, 23);
            this.reservarBtn.TabIndex = 3;
            this.reservarBtn.Text = "Reservar";
            this.reservarBtn.UseVisualStyleBackColor = true;
            this.reservarBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // cantidasAsientoNup
            // 
            this.cantidasAsientoNup.Location = new System.Drawing.Point(11, 25);
            this.cantidasAsientoNup.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.cantidasAsientoNup.Name = "cantidasAsientoNup";
            this.cantidasAsientoNup.Size = new System.Drawing.Size(60, 20);
            this.cantidasAsientoNup.TabIndex = 2;
            // 
            // DestinoCb
            // 
            this.DestinoCb.FormattingEnabled = true;
            this.DestinoCb.Location = new System.Drawing.Point(581, 368);
            this.DestinoCb.Name = "DestinoCb";
            this.DestinoCb.Size = new System.Drawing.Size(121, 21);
            this.DestinoCb.TabIndex = 1;
            // 
            // origenCb
            // 
            this.origenCb.FormattingEnabled = true;
            this.origenCb.Location = new System.Drawing.Point(580, 304);
            this.origenCb.Name = "origenCb";
            this.origenCb.Size = new System.Drawing.Size(121, 21);
            this.origenCb.TabIndex = 0;
            // 
            // Reservas
            // 
            this.ClientSize = new System.Drawing.Size(889, 445);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.origenCb);
            this.Controls.Add(this.DestinoCb);
            this.Name = "Reservas";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidasAsientoNup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.MaskedTextBox txtCantidad;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.MaskedTextBox txtDestino;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.TextBox destino;
        private System.Windows.Forms.TextBox origen;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown cantidasAsientoNup;
        private System.Windows.Forms.ComboBox DestinoCb;
        private System.Windows.Forms.ComboBox origenCb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button reservarBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clumcodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clumOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clumDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn clumFecha;
    }
}