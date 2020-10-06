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
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnRegistros = new System.Windows.Forms.PictureBox();
            this.btnConfiguracion = new System.Windows.Forms.PictureBox();
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
            this.medidorHumedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medidorHumedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.medidorHumedad.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(230)))));
            this.medidorHumedad.InnerMargin = 2;
            this.medidorHumedad.InnerWidth = -1;
            this.medidorHumedad.Location = new System.Drawing.Point(55, 97);
            this.medidorHumedad.MarqueeAnimationSpeed = 2000;
            this.medidorHumedad.Name = "medidorHumedad";
            this.medidorHumedad.OuterColor = System.Drawing.Color.Gray;
            this.medidorHumedad.OuterMargin = -25;
            this.medidorHumedad.OuterWidth = 26;
            this.medidorHumedad.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.medidorHumedad.ProgressWidth = 25;
            this.medidorHumedad.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.medidorHumedad.Size = new System.Drawing.Size(320, 319);
            this.medidorHumedad.StartAngle = 270;
            this.medidorHumedad.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.medidorHumedad.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.medidorHumedad.SubscriptText = "";
            this.medidorHumedad.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.medidorHumedad.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.medidorHumedad.SuperscriptText = "";
            this.medidorHumedad.TabIndex = 0;
            this.medidorHumedad.Text = "Humedad %";
            this.medidorHumedad.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.medidorHumedad.Value = 10;
            this.medidorHumedad.Click += new System.EventHandler(this.medidorHumedad_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.panel1.Location = new System.Drawing.Point(34, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 5);
            this.panel1.TabIndex = 1;
            // 
            // lblConfiguracion
            // 
            this.lblConfiguracion.AutoSize = true;
            this.lblConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfiguracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.lblConfiguracion.Location = new System.Drawing.Point(37, 67);
            this.lblConfiguracion.Name = "lblConfiguracion";
            this.lblConfiguracion.Size = new System.Drawing.Size(96, 15);
            this.lblConfiguracion.TabIndex = 5;
            this.lblConfiguracion.Text = "Configuracion";
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.lblRegistros.Location = new System.Drawing.Point(191, 67);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(68, 15);
            this.lblRegistros.TabIndex = 6;
            this.lblRegistros.Text = "Registros";
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.lblSalir.Location = new System.Drawing.Point(335, 67);
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
            this.btnEncender.Location = new System.Drawing.Point(142, 450);
            this.btnEncender.Name = "btnEncender";
            this.btnEncender.Size = new System.Drawing.Size(136, 42);
            this.btnEncender.TabIndex = 8;
            this.btnEncender.Text = "Encender";
            this.btnEncender.UseVisualStyleBackColor = false;
            this.btnEncender.Click += new System.EventHandler(this.btnEncender_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(321, 529);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(100, 15);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado: Apagado";
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Location = new System.Drawing.Point(3, 529);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(176, 15);
            this.lblFechaHora.TabIndex = 10;
            this.lblFechaHora.Text = "Fecha: 2020/05/10 - Hora: 4:14";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::futureland.Properties.Resources.multiply_1;
            this.btnSalir.Location = new System.Drawing.Point(324, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(51, 44);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 4;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistros
            // 
            this.btnRegistros.Image = global::futureland.Properties.Resources.archive;
            this.btnRegistros.Location = new System.Drawing.Point(194, 12);
            this.btnRegistros.Name = "btnRegistros";
            this.btnRegistros.Size = new System.Drawing.Size(51, 44);
            this.btnRegistros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRegistros.TabIndex = 3;
            this.btnRegistros.TabStop = false;
            this.btnRegistros.Click += new System.EventHandler(this.btnRegistros_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Image = global::futureland.Properties.Resources.settings_6;
            this.btnConfiguracion.Location = new System.Drawing.Point(55, 12);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(51, 44);
            this.btnConfiguracion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnConfiguracion.TabIndex = 2;
            this.btnConfiguracion.TabStop = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(432, 553);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.lblEstado);
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
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFechaHora;
    }
}