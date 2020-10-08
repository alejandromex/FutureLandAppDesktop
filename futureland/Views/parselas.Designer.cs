namespace futureland.Views
{
    partial class parselas
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
            this.btnParcelas = new System.Windows.Forms.Button();
            this.txtNumParselas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnParcelas
            // 
            this.btnParcelas.Location = new System.Drawing.Point(81, 120);
            this.btnParcelas.Name = "btnParcelas";
            this.btnParcelas.Size = new System.Drawing.Size(82, 40);
            this.btnParcelas.TabIndex = 0;
            this.btnParcelas.Text = "Aceptar";
            this.btnParcelas.UseVisualStyleBackColor = true;
            this.btnParcelas.Click += new System.EventHandler(this.btnParcelas_Click);
            // 
            // txtNumParselas
            // 
            this.txtNumParselas.Location = new System.Drawing.Point(37, 78);
            this.txtNumParselas.Name = "txtNumParselas";
            this.txtNumParselas.Size = new System.Drawing.Size(154, 22);
            this.txtNumParselas.TabIndex = 1;
            this.txtNumParselas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumParselas_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Configure el numero de parselas";
            // 
            // parselas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(780, 509);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumParselas);
            this.Controls.Add(this.btnParcelas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "parselas";
            this.Text = "parselas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParcelas;
        private System.Windows.Forms.TextBox txtNumParselas;
        private System.Windows.Forms.Label label1;
    }
}