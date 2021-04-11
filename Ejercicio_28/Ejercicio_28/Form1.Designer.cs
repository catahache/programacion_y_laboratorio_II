namespace Ejercicio_28
{
    partial class frmContador
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
            this.richTxtB = new System.Windows.Forms.RichTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTxtB
            // 
            this.richTxtB.Location = new System.Drawing.Point(9, 12);
            this.richTxtB.Name = "richTxtB";
            this.richTxtB.Size = new System.Drawing.Size(408, 301);
            this.richTxtB.TabIndex = 0;
            this.richTxtB.Text = "";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(342, 319);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmContador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 354);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.richTxtB);
            this.Name = "frmContador";
            this.Text = "Contador de Palabras";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxtB;
        private System.Windows.Forms.Button btnCalcular;
    }
}

