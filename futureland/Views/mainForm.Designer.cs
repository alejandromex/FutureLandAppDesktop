namespace futureland.Views
{
    partial class mainForm
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
            this.medidorHumedad = new CircularProgressBar.CircularProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblConfiguracion = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.lblSalir = new System.Windows.Forms.Label();
            this.btnEncender = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnRegistros = new System.Windows.Forms.PictureBox();
            this.btnConfiguracion = new System.Windows.Forms.PictureBox();
            this.panelParcelas = new System.Windows.Forms.Panel();
            this.btnNotificaciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfiguracion)).BeginInit();
            this.SuspendLayout();
            // 
            // medidorHumedad
            // 
            this.medidorHumedad.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.medidorHumedad.AnimationSpeed = 500;
            this.medidorHumedad.BackColor = System.Drawing.Color.Transparent;
            this.medidorHumedad.Enabled = false;
            this.medidorHumedad.Font = new System.Drawing.Font("Microsoft PhagsPa", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medidorHumedad.ForeColor = System.Drawing.Color.White;
            this.medidorHumedad.InnerColor = System.Drawing.Color.Transparent;
            this.medidorHumedad.InnerMargin = 2;
            this.medidorHumedad.InnerWidth = -1;
            this.medidorHumedad.Location = new System.Drawing.Point(73, 163);
            this.medidorHumedad.Margin = new System.Windows.Forms.Padding(4);
            this.medidorHumedad.MarqueeAnimationSpeed = 2000;
            this.medidorHumedad.Name = "medidorHumedad";
            this.medidorHumedad.OuterColor = System.Drawing.Color.Black;
            this.medidorHumedad.OuterMargin = -25;
            this.medidorHumedad.OuterWidth = 26;
            this.medidorHumedad.ProgressColor = System.Drawing.Color.White;
            this.medidorHumedad.ProgressWidth = 25;
            this.medidorHumedad.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.medidorHumedad.Size = new System.Drawing.Size(427, 393);
            this.medidorHumedad.StartAngle = 270;
            this.medidorHumedad.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.medidorHumedad.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.medidorHumedad.SubscriptText = "";
            this.medidorHumedad.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.medidorHumedad.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.medidorHumedad.SuperscriptText = "";
            this.medidorHumedad.TabIndex = 0;
            this.medidorHumedad.Text = "Parsela #1 Humedad %";
            this.medidorHumedad.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.medidorHumedad.Value = 10;
            this.medidorHumedad.Click += new System.EventHandler(this.medidorHumedad_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.panel1.Location = new System.Drawing.Point(45, 119);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 6);
            this.panel1.TabIndex = 1;
            // 
            // lblConfiguracion
            // 
            this.lblConfiguracion.AutoSize = true;
            this.lblConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.lblConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfiguracion.ForeColor = System.Drawing.Color.White;
            this.lblConfiguracion.Location = new System.Drawing.Point(49, 95);
            this.lblConfiguracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfiguracion.Name = "lblConfiguracion";
            this.lblConfiguracion.Size = new System.Drawing.Size(96, 15);
            this.lblConfiguracion.TabIndex = 5;
            this.lblConfiguracion.Text = "Configuracion";
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.ForeColor = System.Drawing.Color.White;
            this.lblRegistros.Location = new System.Drawing.Point(255, 95);
            this.lblRegistros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(68, 15);
            this.lblRegistros.TabIndex = 6;
            this.lblRegistros.Text = "Registros";
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.BackColor = System.Drawing.Color.Transparent;
            this.lblSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.ForeColor = System.Drawing.Color.White;
            this.lblSalir.Location = new System.Drawing.Point(447, 95);
            this.lblSalir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(37, 15);
            this.lblSalir.TabIndex = 7;
            this.lblSalir.Text = "Salir";
            // 
            // btnEncender
            // 
            this.btnEncender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnEncender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.btnEncender.Location = new System.Drawing.Point(194, 616);
            this.btnEncender.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncender.Name = "btnEncender";
            this.btnEncender.Size = new System.Drawing.Size(181, 52);
            this.btnEncender.TabIndex = 8;
            this.btnEncender.Text = "Encender";
            this.btnEncender.UseVisualStyleBackColor = false;
            this.btnEncender.Click += new System.EventHandler(this.btnEncender_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSalir.Image = global::futureland.Properties.Resources.multiply_1;
            this.btnSalir.Location = new System.Drawing.Point(432, 28);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(68, 54);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 4;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistros
            // 
            this.btnRegistros.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnRegistros.Image = global::futureland.Properties.Resources.archive;
            this.btnRegistros.Location = new System.Drawing.Point(259, 28);
            this.btnRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistros.Name = "btnRegistros";
            this.btnRegistros.Size = new System.Drawing.Size(68, 54);
            this.btnRegistros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRegistros.TabIndex = 3;
            this.btnRegistros.TabStop = false;
            this.btnRegistros.Click += new System.EventHandler(this.btnRegistros_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnConfiguracion.Image = global::futureland.Properties.Resources.settings_6;
            this.btnConfiguracion.Location = new System.Drawing.Point(73, 28);
            this.btnConfiguracion.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(68, 54);
            this.btnConfiguracion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnConfiguracion.TabIndex = 2;
            this.btnConfiguracion.TabStop = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // panelParcelas
            // 
            this.panelParcelas.BackColor = System.Drawing.Color.Transparent;
            this.panelParcelas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelParcelas.Location = new System.Drawing.Point(543, 28);
            this.panelParcelas.Name = "panelParcelas";
            this.panelParcelas.Size = new System.Drawing.Size(649, 576);
            this.panelParcelas.TabIndex = 11;
            // 
            // btnNotificaciones
            // 
            this.btnNotificaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnNotificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotificaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.btnNotificaciones.Location = new System.Drawing.Point(799, 616);
            this.btnNotificaciones.Margin = new System.Windows.Forms.Padding(4);
            this.btnNotificaciones.Name = "btnNotificaciones";
            this.btnNotificaciones.Size = new System.Drawing.Size(181, 52);
            this.btnNotificaciones.TabIndex = 12;
            this.btnNotificaciones.Text = "Notificaciones";
            this.btnNotificaciones.UseVisualStyleBackColor = false;
            this.btnNotificaciones.Click += new System.EventHandler(this.btnNotificaciones_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1218, 681);
            this.Controls.Add(this.btnNotificaciones);
            this.Controls.Add(this.panelParcelas);
            this.Controls.Add(this.btnEncender);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.lblConfiguracion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistros);
            this.Controls.Add(this.btnConfiguracion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.medidorHumedad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfiguracion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar medidorHumedad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnConfiguracion;
        private System.Windows.Forms.PictureBox btnRegistros;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Label lblConfiguracion;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.Button btnEncender;
        private System.Windows.Forms.Panel panelParcelas;
        private System.Windows.Forms.Button btnNotificaciones;
    }
}