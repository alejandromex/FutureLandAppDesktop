namespace futureland.Views
{
    partial class registroForm
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
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtHumedadMin = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtHumedadMax = new System.Windows.Forms.TextBox();
            this.lblHumedad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFiltro = new System.Windows.Forms.CheckBox();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminarRegistros = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Humedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Humedad,
            this.Fecha});
            this.dgvRegistros.Location = new System.Drawing.Point(25, 82);
            this.dgvRegistros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.RowHeadersWidth = 51;
            this.dgvRegistros.Size = new System.Drawing.Size(449, 720);
            this.dgvRegistros.TabIndex = 6;
            this.dgvRegistros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellContentClick);
            this.dgvRegistros.SelectionChanged += new System.EventHandler(this.dgvRegistros_SelectionChanged);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(559, 82);
            this.btnBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(179, 55);
            this.btnBusqueda.TabIndex = 7;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd.MM.yyyy";
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(531, 288);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(265, 22);
            this.dtpFecha.TabIndex = 8;
            // 
            // txtHumedadMin
            // 
            this.txtHumedadMin.Enabled = false;
            this.txtHumedadMin.Location = new System.Drawing.Point(511, 517);
            this.txtHumedadMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHumedadMin.Name = "txtHumedadMin";
            this.txtHumedadMin.Size = new System.Drawing.Size(132, 22);
            this.txtHumedadMin.TabIndex = 9;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(601, 254);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(90, 17);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha Inicial:";
            // 
            // txtHumedadMax
            // 
            this.txtHumedadMax.Enabled = false;
            this.txtHumedadMax.Location = new System.Drawing.Point(679, 517);
            this.txtHumedadMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHumedadMax.Name = "txtHumedadMax";
            this.txtHumedadMax.Size = new System.Drawing.Size(132, 22);
            this.txtHumedadMax.TabIndex = 11;
            // 
            // lblHumedad
            // 
            this.lblHumedad.AutoSize = true;
            this.lblHumedad.Location = new System.Drawing.Point(619, 459);
            this.lblHumedad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHumedad.Name = "lblHumedad";
            this.lblHumedad.Size = new System.Drawing.Size(69, 17);
            this.lblHumedad.TabIndex = 12;
            this.lblHumedad.Text = "Humedad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 489);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Minima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(708, 489);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Maxima";
            // 
            // cbFiltro
            // 
            this.cbFiltro.AutoSize = true;
            this.cbFiltro.Location = new System.Drawing.Point(587, 181);
            this.cbFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(104, 21);
            this.cbFiltro.TabIndex = 15;
            this.cbFiltro.Text = "Activar filtro";
            this.cbFiltro.UseVisualStyleBackColor = true;
            this.cbFiltro.CheckedChanged += new System.EventHandler(this.cbFiltro_CheckedChanged);
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.CustomFormat = "dd.MM.yyyy";
            this.dtpFechaFinal.Enabled = false;
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFinal.Location = new System.Drawing.Point(531, 384);
            this.dtpFechaFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaFinal.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(601, 348);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Fecha Inicial:";
            // 
            // btnEliminarRegistros
            // 
            this.btnEliminarRegistros.Enabled = false;
            this.btnEliminarRegistros.Location = new System.Drawing.Point(496, 769);
            this.btnEliminarRegistros.Name = "btnEliminarRegistros";
            this.btnEliminarRegistros.Size = new System.Drawing.Size(112, 33);
            this.btnEliminarRegistros.TabIndex = 18;
            this.btnEliminarRegistros.Text = "Eliminar registros";
            this.btnEliminarRegistros.UseVisualStyleBackColor = true;
            this.btnEliminarRegistros.Click += new System.EventHandler(this.btnEliminarRegistros_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // Humedad
            // 
            this.Humedad.HeaderText = "Humedad";
            this.Humedad.MinimumWidth = 6;
            this.Humedad.Name = "Humedad";
            this.Humedad.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 125;
            // 
            // registroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(845, 862);
            this.Controls.Add(this.btnEliminarRegistros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHumedad);
            this.Controls.Add(this.txtHumedadMax);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtHumedadMin);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.dgvRegistros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "registroForm";
            this.Text = "registroForm";
            this.Load += new System.EventHandler(this.registroForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtHumedadMin;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtHumedadMax;
        private System.Windows.Forms.Label lblHumedad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbFiltro;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminarRegistros;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Humedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}