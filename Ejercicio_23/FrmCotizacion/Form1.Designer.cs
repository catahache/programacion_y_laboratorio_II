namespace FrmCotizacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.btnLockCotizacion = new System.Windows.Forms.Button();
            this.imgLLock = new System.Windows.Forms.ImageList(this.components);
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtBEuros = new System.Windows.Forms.TextBox();
            this.txtBDolares = new System.Windows.Forms.TextBox();
            this.txtBPesos = new System.Windows.Forms.TextBox();
            this.btnConvertEuro = new System.Windows.Forms.Button();
            this.btnConvertDolar = new System.Windows.Forms.Button();
            this.btnConvertPeso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBEuroaEuro = new System.Windows.Forms.TextBox();
            this.txtBEuroADolar = new System.Windows.Forms.TextBox();
            this.txtEuroAPeso = new System.Windows.Forms.TextBox();
            this.txtBCotizPeso = new System.Windows.Forms.TextBox();
            this.txtBCotizDolar = new System.Windows.Forms.TextBox();
            this.txtBCotizEuro = new System.Windows.Forms.TextBox();
            this.txtBDolarAPeso = new System.Windows.Forms.TextBox();
            this.txtBDolarADolar = new System.Windows.Forms.TextBox();
            this.txtBDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtBPesoAPeso = new System.Windows.Forms.TextBox();
            this.txtBPesoADolar = new System.Windows.Forms.TextBox();
            this.txtBPesoAEuro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Location = new System.Drawing.Point(71, 30);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(66, 13);
            this.lblCotizacion.TabIndex = 0;
            this.lblCotizacion.Text = "Cotizacion";
            // 
            // btnLockCotizacion
            // 
            this.btnLockCotizacion.ImageIndex = 1;
            this.btnLockCotizacion.ImageList = this.imgLLock;
            this.btnLockCotizacion.Location = new System.Drawing.Point(160, 25);
            this.btnLockCotizacion.Name = "btnLockCotizacion";
            this.btnLockCotizacion.Size = new System.Drawing.Size(87, 23);
            this.btnLockCotizacion.TabIndex = 0;
            this.btnLockCotizacion.UseVisualStyleBackColor = true;
            this.btnLockCotizacion.Click += new System.EventHandler(this.btnLockCotizacion_Click);
            // 
            // imgLLock
            // 
            this.imgLLock.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLLock.ImageStream")));
            this.imgLLock.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLLock.Images.SetKeyName(0, "closed-lock.png");
            this.imgLLock.Images.SetKeyName(1, "open-lock.png");
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(16, 88);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(33, 13);
            this.lblEuro.TabIndex = 5;
            this.lblEuro.Text = "Euro";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Location = new System.Drawing.Point(16, 117);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(37, 13);
            this.lblDolar.TabIndex = 6;
            this.lblDolar.Text = "Dolar";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(18, 150);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(35, 13);
            this.lblPeso.TabIndex = 7;
            this.lblPeso.Text = "Peso";
            // 
            // txtBEuros
            // 
            this.txtBEuros.Location = new System.Drawing.Point(74, 85);
            this.txtBEuros.Name = "txtBEuros";
            this.txtBEuros.Size = new System.Drawing.Size(74, 20);
            this.txtBEuros.TabIndex = 8;
            // 
            // txtBDolares
            // 
            this.txtBDolares.Location = new System.Drawing.Point(74, 117);
            this.txtBDolares.Name = "txtBDolares";
            this.txtBDolares.Size = new System.Drawing.Size(74, 20);
            this.txtBDolares.TabIndex = 9;
            // 
            // txtBPesos
            // 
            this.txtBPesos.Location = new System.Drawing.Point(74, 147);
            this.txtBPesos.Name = "txtBPesos";
            this.txtBPesos.Size = new System.Drawing.Size(74, 20);
            this.txtBPesos.TabIndex = 10;
            // 
            // btnConvertEuro
            // 
            this.btnConvertEuro.Location = new System.Drawing.Point(160, 82);
            this.btnConvertEuro.Name = "btnConvertEuro";
            this.btnConvertEuro.Size = new System.Drawing.Size(87, 23);
            this.btnConvertEuro.TabIndex = 11;
            this.btnConvertEuro.Text = "->";
            this.btnConvertEuro.UseVisualStyleBackColor = true;
            this.btnConvertEuro.Click += new System.EventHandler(this.btnConvertEuro_Click);
            // 
            // btnConvertDolar
            // 
            this.btnConvertDolar.Location = new System.Drawing.Point(160, 115);
            this.btnConvertDolar.Name = "btnConvertDolar";
            this.btnConvertDolar.Size = new System.Drawing.Size(87, 23);
            this.btnConvertDolar.TabIndex = 12;
            this.btnConvertDolar.Text = "->";
            this.btnConvertDolar.UseVisualStyleBackColor = true;
            this.btnConvertDolar.Click += new System.EventHandler(this.btnConvertDolar_Click);
            // 
            // btnConvertPeso
            // 
            this.btnConvertPeso.Location = new System.Drawing.Point(160, 145);
            this.btnConvertPeso.Name = "btnConvertPeso";
            this.btnConvertPeso.Size = new System.Drawing.Size(87, 23);
            this.btnConvertPeso.TabIndex = 13;
            this.btnConvertPeso.Text = "->";
            this.btnConvertPeso.UseVisualStyleBackColor = true;
            this.btnConvertPeso.Click += new System.EventHandler(this.btnConvertPeso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Dolar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Euro";
            // 
            // txtBEuroaEuro
            // 
            this.txtBEuroaEuro.Enabled = false;
            this.txtBEuroaEuro.Location = new System.Drawing.Point(265, 82);
            this.txtBEuroaEuro.Name = "txtBEuroaEuro";
            this.txtBEuroaEuro.Size = new System.Drawing.Size(74, 20);
            this.txtBEuroaEuro.TabIndex = 17;
            // 
            // txtBEuroADolar
            // 
            this.txtBEuroADolar.Enabled = false;
            this.txtBEuroADolar.Location = new System.Drawing.Point(345, 82);
            this.txtBEuroADolar.Name = "txtBEuroADolar";
            this.txtBEuroADolar.Size = new System.Drawing.Size(74, 20);
            this.txtBEuroADolar.TabIndex = 18;
            // 
            // txtEuroAPeso
            // 
            this.txtEuroAPeso.Enabled = false;
            this.txtEuroAPeso.Location = new System.Drawing.Point(425, 82);
            this.txtEuroAPeso.Name = "txtEuroAPeso";
            this.txtEuroAPeso.Size = new System.Drawing.Size(74, 20);
            this.txtEuroAPeso.TabIndex = 19;
            // 
            // txtBCotizPeso
            // 
            this.txtBCotizPeso.Location = new System.Drawing.Point(425, 26);
            this.txtBCotizPeso.Name = "txtBCotizPeso";
            this.txtBCotizPeso.Size = new System.Drawing.Size(74, 20);
            this.txtBCotizPeso.TabIndex = 3;
            this.txtBCotizPeso.Leave += new System.EventHandler(this.txtBCotizPeso_Leave);
            // 
            // txtBCotizDolar
            // 
            this.txtBCotizDolar.Location = new System.Drawing.Point(345, 26);
            this.txtBCotizDolar.Name = "txtBCotizDolar";
            this.txtBCotizDolar.ReadOnly = true;
            this.txtBCotizDolar.Size = new System.Drawing.Size(74, 20);
            this.txtBCotizDolar.TabIndex = 2;
            this.txtBCotizDolar.Text = "1";
            // 
            // txtBCotizEuro
            // 
            this.txtBCotizEuro.Location = new System.Drawing.Point(265, 26);
            this.txtBCotizEuro.Name = "txtBCotizEuro";
            this.txtBCotizEuro.Size = new System.Drawing.Size(74, 20);
            this.txtBCotizEuro.TabIndex = 1;
            this.txtBCotizEuro.Leave += new System.EventHandler(this.txtBCotizEuro_Leave);
            // 
            // txtBDolarAPeso
            // 
            this.txtBDolarAPeso.Enabled = false;
            this.txtBDolarAPeso.Location = new System.Drawing.Point(425, 118);
            this.txtBDolarAPeso.Name = "txtBDolarAPeso";
            this.txtBDolarAPeso.Size = new System.Drawing.Size(74, 20);
            this.txtBDolarAPeso.TabIndex = 25;
            // 
            // txtBDolarADolar
            // 
            this.txtBDolarADolar.Enabled = false;
            this.txtBDolarADolar.Location = new System.Drawing.Point(345, 118);
            this.txtBDolarADolar.Name = "txtBDolarADolar";
            this.txtBDolarADolar.Size = new System.Drawing.Size(74, 20);
            this.txtBDolarADolar.TabIndex = 24;
            // 
            // txtBDolarAEuro
            // 
            this.txtBDolarAEuro.Enabled = false;
            this.txtBDolarAEuro.Location = new System.Drawing.Point(265, 118);
            this.txtBDolarAEuro.Name = "txtBDolarAEuro";
            this.txtBDolarAEuro.Size = new System.Drawing.Size(74, 20);
            this.txtBDolarAEuro.TabIndex = 23;
            // 
            // txtBPesoAPeso
            // 
            this.txtBPesoAPeso.Enabled = false;
            this.txtBPesoAPeso.Location = new System.Drawing.Point(425, 151);
            this.txtBPesoAPeso.Name = "txtBPesoAPeso";
            this.txtBPesoAPeso.Size = new System.Drawing.Size(74, 20);
            this.txtBPesoAPeso.TabIndex = 28;
            // 
            // txtBPesoADolar
            // 
            this.txtBPesoADolar.Enabled = false;
            this.txtBPesoADolar.Location = new System.Drawing.Point(345, 151);
            this.txtBPesoADolar.Name = "txtBPesoADolar";
            this.txtBPesoADolar.Size = new System.Drawing.Size(74, 20);
            this.txtBPesoADolar.TabIndex = 27;
            // 
            // txtBPesoAEuro
            // 
            this.txtBPesoAEuro.Enabled = false;
            this.txtBPesoAEuro.Location = new System.Drawing.Point(265, 151);
            this.txtBPesoAEuro.Name = "txtBPesoAEuro";
            this.txtBPesoAEuro.Size = new System.Drawing.Size(74, 20);
            this.txtBPesoAEuro.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 188);
            this.Controls.Add(this.txtBPesoAPeso);
            this.Controls.Add(this.txtBPesoADolar);
            this.Controls.Add(this.txtBPesoAEuro);
            this.Controls.Add(this.txtBDolarAPeso);
            this.Controls.Add(this.txtBDolarADolar);
            this.Controls.Add(this.txtBDolarAEuro);
            this.Controls.Add(this.txtBCotizPeso);
            this.Controls.Add(this.txtBCotizDolar);
            this.Controls.Add(this.txtBCotizEuro);
            this.Controls.Add(this.txtEuroAPeso);
            this.Controls.Add(this.txtBEuroADolar);
            this.Controls.Add(this.txtBEuroaEuro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConvertPeso);
            this.Controls.Add(this.btnConvertDolar);
            this.Controls.Add(this.btnConvertEuro);
            this.Controls.Add(this.txtBPesos);
            this.Controls.Add(this.txtBDolares);
            this.Controls.Add(this.txtBEuros);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.btnLockCotizacion);
            this.Controls.Add(this.lblCotizacion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCotizacion;
        private System.Windows.Forms.Button btnLockCotizacion;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtBEuros;
        private System.Windows.Forms.TextBox txtBDolares;
        private System.Windows.Forms.TextBox txtBPesos;
        private System.Windows.Forms.Button btnConvertEuro;
        private System.Windows.Forms.Button btnConvertDolar;
        private System.Windows.Forms.Button btnConvertPeso;
        private System.Windows.Forms.ImageList imgLLock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBEuroaEuro;
        private System.Windows.Forms.TextBox txtBEuroADolar;
        private System.Windows.Forms.TextBox txtEuroAPeso;
        private System.Windows.Forms.TextBox txtBCotizPeso;
        private System.Windows.Forms.TextBox txtBCotizDolar;
        private System.Windows.Forms.TextBox txtBCotizEuro;
        private System.Windows.Forms.TextBox txtBDolarAPeso;
        private System.Windows.Forms.TextBox txtBDolarADolar;
        private System.Windows.Forms.TextBox txtBDolarAEuro;
        private System.Windows.Forms.TextBox txtBPesoAPeso;
        private System.Windows.Forms.TextBox txtBPesoADolar;
        private System.Windows.Forms.TextBox txtBPesoAEuro;
    }
}

