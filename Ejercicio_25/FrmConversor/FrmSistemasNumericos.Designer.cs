namespace FrmConversor
{
    partial class FrmSistemasNumericos
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
            this.lblBinADec = new System.Windows.Forms.Label();
            this.lblDecABin = new System.Windows.Forms.Label();
            this.btnBinADec = new System.Windows.Forms.Button();
            this.btnDecABin = new System.Windows.Forms.Button();
            this.txtBBinADecIN = new System.Windows.Forms.TextBox();
            this.txtBDecABinIN = new System.Windows.Forms.TextBox();
            this.txtBBinADecOUT = new System.Windows.Forms.TextBox();
            this.txtBDecABinOUT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBinADec
            // 
            this.lblBinADec.AutoSize = true;
            this.lblBinADec.Location = new System.Drawing.Point(42, 48);
            this.lblBinADec.Name = "lblBinADec";
            this.lblBinADec.Size = new System.Drawing.Size(89, 13);
            this.lblBinADec.TabIndex = 0;
            this.lblBinADec.Text = "Binario a Decimal";
            // 
            // lblDecABin
            // 
            this.lblDecABin.AutoSize = true;
            this.lblDecABin.Location = new System.Drawing.Point(42, 89);
            this.lblDecABin.Name = "lblDecABin";
            this.lblDecABin.Size = new System.Drawing.Size(89, 13);
            this.lblDecABin.TabIndex = 1;
            this.lblDecABin.Text = "Decimal a Binario";
            // 
            // btnBinADec
            // 
            this.btnBinADec.Location = new System.Drawing.Point(224, 43);
            this.btnBinADec.Name = "btnBinADec";
            this.btnBinADec.Size = new System.Drawing.Size(75, 23);
            this.btnBinADec.TabIndex = 2;
            this.btnBinADec.Text = "->";
            this.btnBinADec.UseVisualStyleBackColor = true;
            this.btnBinADec.Click += new System.EventHandler(this.btnBinADec_Click);
            // 
            // btnDecABin
            // 
            this.btnDecABin.Location = new System.Drawing.Point(224, 84);
            this.btnDecABin.Name = "btnDecABin";
            this.btnDecABin.Size = new System.Drawing.Size(75, 23);
            this.btnDecABin.TabIndex = 3;
            this.btnDecABin.Text = "->";
            this.btnDecABin.UseVisualStyleBackColor = true;
            this.btnDecABin.Click += new System.EventHandler(this.btnDecABin_Click);
            // 
            // txtBBinADecIN
            // 
            this.txtBBinADecIN.Location = new System.Drawing.Point(137, 45);
            this.txtBBinADecIN.Name = "txtBBinADecIN";
            this.txtBBinADecIN.Size = new System.Drawing.Size(81, 20);
            this.txtBBinADecIN.TabIndex = 4;
            // 
            // txtBDecABinIN
            // 
            this.txtBDecABinIN.Location = new System.Drawing.Point(137, 86);
            this.txtBDecABinIN.Name = "txtBDecABinIN";
            this.txtBDecABinIN.Size = new System.Drawing.Size(81, 20);
            this.txtBDecABinIN.TabIndex = 5;
            // 
            // txtBBinADecOUT
            // 
            this.txtBBinADecOUT.Location = new System.Drawing.Point(305, 45);
            this.txtBBinADecOUT.Name = "txtBBinADecOUT";
            this.txtBBinADecOUT.Size = new System.Drawing.Size(81, 20);
            this.txtBBinADecOUT.TabIndex = 6;
            // 
            // txtBDecABinOUT
            // 
            this.txtBDecABinOUT.Location = new System.Drawing.Point(305, 86);
            this.txtBDecABinOUT.Name = "txtBDecABinOUT";
            this.txtBDecABinOUT.Size = new System.Drawing.Size(81, 20);
            this.txtBDecABinOUT.TabIndex = 7;
            // 
            // FrmSistemasNumericos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 156);
            this.Controls.Add(this.txtBDecABinOUT);
            this.Controls.Add(this.txtBBinADecOUT);
            this.Controls.Add(this.txtBDecABinIN);
            this.Controls.Add(this.txtBBinADecIN);
            this.Controls.Add(this.btnDecABin);
            this.Controls.Add(this.btnBinADec);
            this.Controls.Add(this.lblDecABin);
            this.Controls.Add(this.lblBinADec);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(453, 195);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(453, 195);
            this.Name = "FrmSistemasNumericos";
            this.Text = "Conversor Numerico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBinADec;
        private System.Windows.Forms.Label lblDecABin;
        private System.Windows.Forms.Button btnBinADec;
        private System.Windows.Forms.Button btnDecABin;
        private System.Windows.Forms.TextBox txtBBinADecIN;
        private System.Windows.Forms.TextBox txtBDecABinIN;
        private System.Windows.Forms.TextBox txtBBinADecOUT;
        private System.Windows.Forms.TextBox txtBDecABinOUT;
    }
}

