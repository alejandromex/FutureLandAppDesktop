namespace futureland.Views
{
    partial class configuracionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(configuracionForm));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbServidores = new System.Windows.Forms.ComboBox();
            this.cmbCom = new System.Windows.Forms.ComboBox();
            this.lblServidores = new System.Windows.Forms.Label();
            this.lblCom = new System.Windows.Forms.Label();
            this.listParselas = new System.Windows.Forms.ListBox();
            this.lblNumeroDeParselas = new System.Windows.Forms.Label();
            this.lblNuevaParsela = new System.Windows.Forms.Label();
            this.txtNombreParsela = new System.Windows.Forms.TextBox();
            this.btnRegistrarParsela = new System.Windows.Forms.Button();
            this.btnEliminarParsela = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(648, 411);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(160, 34);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar y conectar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbServidores
            // 
            this.cmbServidores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServidores.FormattingEnabled = true;
            this.cmbServidores.Location = new System.Drawing.Point(348, 19);
            this.cmbServidores.Margin = new System.Windows.Forms.Padding(4);
            this.cmbServidores.Name = "cmbServidores";
            this.cmbServidores.Size = new System.Drawing.Size(313, 24);
            this.cmbServidores.TabIndex = 2;
            // 
            // cmbCom
            // 
            this.cmbCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCom.FormattingEnabled = true;
            this.cmbCom.Location = new System.Drawing.Point(348, 73);
            this.cmbCom.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCom.Name = "cmbCom";
            this.cmbCom.Size = new System.Drawing.Size(313, 24);
            this.cmbCom.TabIndex = 3;
            // 
            // lblServidores
            // 
            this.lblServidores.AutoSize = true;
            this.lblServidores.BackColor = System.Drawing.Color.Transparent;
            this.lblServidores.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServidores.ForeColor = System.Drawing.Color.White;
            this.lblServidores.Location = new System.Drawing.Point(12, 19);
            this.lblServidores.Name = "lblServidores";
            this.lblServidores.Size = new System.Drawing.Size(286, 29);
            this.lblServidores.TabIndex = 4;
            this.lblServidores.Text = "Servidores Disponibles";
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.BackColor = System.Drawing.Color.Transparent;
            this.lblCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCom.ForeColor = System.Drawing.Color.White;
            this.lblCom.Location = new System.Drawing.Point(12, 68);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(328, 29);
            this.lblCom.TabIndex = 5;
            this.lblCom.Text = "Entradas COM Disponibles";
            // 
            // listParselas
            // 
            this.listParselas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listParselas.FormattingEnabled = true;
            this.listParselas.ItemHeight = 20;
            this.listParselas.Location = new System.Drawing.Point(12, 250);
            this.listParselas.Name = "listParselas";
            this.listParselas.Size = new System.Drawing.Size(265, 164);
            this.listParselas.TabIndex = 6;
            // 
            // lblNumeroDeParselas
            // 
            this.lblNumeroDeParselas.AutoSize = true;
            this.lblNumeroDeParselas.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroDeParselas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDeParselas.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNumeroDeParselas.Location = new System.Drawing.Point(13, 429);
            this.lblNumeroDeParselas.Name = "lblNumeroDeParselas";
            this.lblNumeroDeParselas.Size = new System.Drawing.Size(200, 20);
            this.lblNumeroDeParselas.TabIndex = 7;
            this.lblNumeroDeParselas.Text = "Numero de parselas: 0";
            // 
            // lblNuevaParsela
            // 
            this.lblNuevaParsela.AutoSize = true;
            this.lblNuevaParsela.BackColor = System.Drawing.Color.Transparent;
            this.lblNuevaParsela.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaParsela.ForeColor = System.Drawing.Color.White;
            this.lblNuevaParsela.Location = new System.Drawing.Point(12, 208);
            this.lblNuevaParsela.Name = "lblNuevaParsela";
            this.lblNuevaParsela.Size = new System.Drawing.Size(197, 29);
            this.lblNuevaParsela.TabIndex = 8;
            this.lblNuevaParsela.Text = "Nueva Parsela: ";
            this.lblNuevaParsela.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNombreParsela
            // 
            this.txtNombreParsela.Location = new System.Drawing.Point(315, 215);
            this.txtNombreParsela.Name = "txtNombreParsela";
            this.txtNombreParsela.Size = new System.Drawing.Size(313, 22);
            this.txtNombreParsela.TabIndex = 9;
            // 
            // btnRegistrarParsela
            // 
            this.btnRegistrarParsela.Location = new System.Drawing.Point(285, 264);
            this.btnRegistrarParsela.Name = "btnRegistrarParsela";
            this.btnRegistrarParsela.Size = new System.Drawing.Size(152, 34);
            this.btnRegistrarParsela.TabIndex = 10;
            this.btnRegistrarParsela.Text = "Registrar Parsela";
            this.btnRegistrarParsela.UseVisualStyleBackColor = true;
            this.btnRegistrarParsela.Click += new System.EventHandler(this.btnRegistrarParsela_Click);
            // 
            // btnEliminarParsela
            // 
            this.btnEliminarParsela.Location = new System.Drawing.Point(285, 315);
            this.btnEliminarParsela.Name = "btnEliminarParsela";
            this.btnEliminarParsela.Size = new System.Drawing.Size(152, 37);
            this.btnEliminarParsela.TabIndex = 11;
            this.btnEliminarParsela.Text = "Borrar ultimo";
            this.btnEliminarParsela.UseVisualStyleBackColor = true;
            this.btnEliminarParsela.Click += new System.EventHandler(this.btnEliminarParsela_Click);
            // 
            // configuracionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 458);
            this.Controls.Add(this.btnEliminarParsela);
            this.Controls.Add(this.btnRegistrarParsela);
            this.Controls.Add(this.txtNombreParsela);
            this.Controls.Add(this.lblNuevaParsela);
            this.Controls.Add(this.lblNumeroDeParselas);
            this.Controls.Add(this.listParselas);
            this.Controls.Add(this.lblCom);
            this.Controls.Add(this.lblServidores);
            this.Controls.Add(this.cmbCom);
            this.Controls.Add(this.cmbServidores);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "configuracionForm";
            this.Text = "Configuraciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.configuracionForm_FormClosed);
            this.Load += new System.EventHandler(this.configuracionForm_Load);
            this.Resize += new System.EventHandler(this.configuracionForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbServidores;
        private System.Windows.Forms.ComboBox cmbCom;
        private System.Windows.Forms.Label lblServidores;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.ListBox listParselas;
        private System.Windows.Forms.Label lblNumeroDeParselas;
        private System.Windows.Forms.Label lblNuevaParsela;
        private System.Windows.Forms.TextBox txtNombreParsela;
        private System.Windows.Forms.Button btnRegistrarParsela;
        private System.Windows.Forms.Button btnEliminarParsela;
    }
}