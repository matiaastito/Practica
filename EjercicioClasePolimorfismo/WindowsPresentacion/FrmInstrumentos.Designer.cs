namespace WindowsPresentacion
{
    partial class FrmInstrumentos
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
            this.btnAfinarGuitarra = new System.Windows.Forms.Button();
            this.btnAfinarViolin = new System.Windows.Forms.Button();
            this.btnAfinarPiano = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAfinarGuitarra
            // 
            this.btnAfinarGuitarra.Location = new System.Drawing.Point(80, 110);
            this.btnAfinarGuitarra.Name = "btnAfinarGuitarra";
            this.btnAfinarGuitarra.Size = new System.Drawing.Size(172, 24);
            this.btnAfinarGuitarra.TabIndex = 0;
            this.btnAfinarGuitarra.Text = "Afinar Guitarra";
            this.btnAfinarGuitarra.UseVisualStyleBackColor = true;
            this.btnAfinarGuitarra.Click += new System.EventHandler(this.btnAfinarGuitarra_Click);
            // 
            // btnAfinarViolin
            // 
            this.btnAfinarViolin.Location = new System.Drawing.Point(293, 110);
            this.btnAfinarViolin.Name = "btnAfinarViolin";
            this.btnAfinarViolin.Size = new System.Drawing.Size(172, 25);
            this.btnAfinarViolin.TabIndex = 1;
            this.btnAfinarViolin.Text = "Afinar Violin";
            this.btnAfinarViolin.UseVisualStyleBackColor = true;
            this.btnAfinarViolin.Click += new System.EventHandler(this.btnAfinarViolin_Click);
            // 
            // btnAfinarPiano
            // 
            this.btnAfinarPiano.Location = new System.Drawing.Point(492, 110);
            this.btnAfinarPiano.Name = "btnAfinarPiano";
            this.btnAfinarPiano.Size = new System.Drawing.Size(172, 24);
            this.btnAfinarPiano.TabIndex = 2;
            this.btnAfinarPiano.Text = "Afinar Piano";
            this.btnAfinarPiano.UseVisualStyleBackColor = true;
            this.btnAfinarPiano.Click += new System.EventHandler(this.btnAfinarPiano_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAfinarPiano);
            this.Controls.Add(this.btnAfinarViolin);
            this.Controls.Add(this.btnAfinarGuitarra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAfinarGuitarra;
        private System.Windows.Forms.Button btnAfinarViolin;
        private System.Windows.Forms.Button btnAfinarPiano;
    }
}

