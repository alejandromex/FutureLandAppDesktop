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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbServidores = new System.Windows.Forms.ComboBox();
            this.cmbCom = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(397, 21);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 28);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar y conectar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbServidores
            // 
            this.cmbServidores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServidores.FormattingEnabled = true;
            this.cmbServidores.Location = new System.Drawing.Point(12, 21);
            this.cmbServidores.Name = "cmbServidores";
            this.cmbServidores.Size = new System.Drawing.Size(236, 21);
            this.cmbServidores.TabIndex = 2;
            // 
            // cmbCom
            // 
            this.cmbCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCom.FormattingEnabled = true;
            this.cmbCom.Location = new System.Drawing.Point(268, 21);
            this.cmbCom.Name = "cmbCom";
            this.cmbCom.Size = new System.Drawing.Size(114, 21);
            this.cmbCom.TabIndex = 3;
            // 
            // configuracionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(528, 128);
            this.Controls.Add(this.cmbCom);
            this.Controls.Add(this.cmbServidores);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "configuracionForm";
            this.Text = "configuracionForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.configuracionForm_FormClosed);
            this.Load += new System.EventHandler(this.configuracionForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbServidores;
        private System.Windows.Forms.ComboBox cmbCom;
    }
}