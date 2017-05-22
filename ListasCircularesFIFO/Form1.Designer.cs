namespace ListasCircularesFIFO
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
            this.buttonSimular = new System.Windows.Forms.Button();
            this.textBoxAtendidos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSimular
            // 
            this.buttonSimular.Location = new System.Drawing.Point(234, 285);
            this.buttonSimular.Name = "buttonSimular";
            this.buttonSimular.Size = new System.Drawing.Size(93, 36);
            this.buttonSimular.TabIndex = 0;
            this.buttonSimular.Text = "Simular";
            this.buttonSimular.UseVisualStyleBackColor = true;
            this.buttonSimular.Click += new System.EventHandler(this.buttonSimular_Click);
            // 
            // textBoxAtendidos
            // 
            this.textBoxAtendidos.Location = new System.Drawing.Point(89, 94);
            this.textBoxAtendidos.Multiline = true;
            this.textBoxAtendidos.Name = "textBoxAtendidos";
            this.textBoxAtendidos.Size = new System.Drawing.Size(409, 79);
            this.textBoxAtendidos.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 386);
            this.Controls.Add(this.textBoxAtendidos);
            this.Controls.Add(this.buttonSimular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSimular;
        private System.Windows.Forms.TextBox textBoxAtendidos;
    }
}

