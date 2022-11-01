namespace WindowsPresentacion
{
    partial class FrmAnimales
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
            this.btnAlimentoLeon = new System.Windows.Forms.Button();
            this.btnAlimentoLoro = new System.Windows.Forms.Button();
            this.btnAlimentoConejo = new System.Windows.Forms.Button();
            this.btnMostrarLeon = new System.Windows.Forms.Button();
            this.btnMostrarLoro = new System.Windows.Forms.Button();
            this.btnMostrarConejo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlimentoLeon
            // 
            this.btnAlimentoLeon.Location = new System.Drawing.Point(80, 250);
            this.btnAlimentoLeon.Name = "btnAlimentoLeon";
            this.btnAlimentoLeon.Size = new System.Drawing.Size(120, 23);
            this.btnAlimentoLeon.TabIndex = 0;
            this.btnAlimentoLeon.Text = "Alimento Leon";
            this.btnAlimentoLeon.UseVisualStyleBackColor = true;
            this.btnAlimentoLeon.Click += new System.EventHandler(this.btnAlimentarLeon_Click);
            // 
            // btnAlimentoLoro
            // 
            this.btnAlimentoLoro.Location = new System.Drawing.Point(266, 250);
            this.btnAlimentoLoro.Name = "btnAlimentoLoro";
            this.btnAlimentoLoro.Size = new System.Drawing.Size(124, 23);
            this.btnAlimentoLoro.TabIndex = 1;
            this.btnAlimentoLoro.Text = "Alimento Loro";
            this.btnAlimentoLoro.UseVisualStyleBackColor = true;
            this.btnAlimentoLoro.Click += new System.EventHandler(this.btnAlimentarLoro_Click);
            // 
            // btnAlimentoConejo
            // 
            this.btnAlimentoConejo.Location = new System.Drawing.Point(467, 250);
            this.btnAlimentoConejo.Name = "btnAlimentoConejo";
            this.btnAlimentoConejo.Size = new System.Drawing.Size(132, 23);
            this.btnAlimentoConejo.TabIndex = 2;
            this.btnAlimentoConejo.Text = "Alimento Conejo";
            this.btnAlimentoConejo.UseVisualStyleBackColor = true;
            this.btnAlimentoConejo.Click += new System.EventHandler(this.btnAlimentarConejo_Click);
            // 
            // btnMostrarLeon
            // 
            this.btnMostrarLeon.Location = new System.Drawing.Point(80, 128);
            this.btnMostrarLeon.Name = "btnMostrarLeon";
            this.btnMostrarLeon.Size = new System.Drawing.Size(120, 24);
            this.btnMostrarLeon.TabIndex = 3;
            this.btnMostrarLeon.Text = "Mostrar Leon";
            this.btnMostrarLeon.UseVisualStyleBackColor = true;
            this.btnMostrarLeon.Click += new System.EventHandler(this.btnMostrarLeon_Click);
            // 
            // btnMostrarLoro
            // 
            this.btnMostrarLoro.Location = new System.Drawing.Point(266, 128);
            this.btnMostrarLoro.Name = "btnMostrarLoro";
            this.btnMostrarLoro.Size = new System.Drawing.Size(124, 24);
            this.btnMostrarLoro.TabIndex = 4;
            this.btnMostrarLoro.Text = "Mostrar Loro";
            this.btnMostrarLoro.UseVisualStyleBackColor = true;
            this.btnMostrarLoro.Click += new System.EventHandler(this.btnMostrarLoro_Click);
            // 
            // btnMostrarConejo
            // 
            this.btnMostrarConejo.Location = new System.Drawing.Point(467, 128);
            this.btnMostrarConejo.Name = "btnMostrarConejo";
            this.btnMostrarConejo.Size = new System.Drawing.Size(132, 24);
            this.btnMostrarConejo.TabIndex = 5;
            this.btnMostrarConejo.Text = "Mostrar Conejo";
            this.btnMostrarConejo.UseVisualStyleBackColor = true;
            this.btnMostrarConejo.Click += new System.EventHandler(this.btnMostrarConejo_Click);
            // 
            // FrmAnimales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarConejo);
            this.Controls.Add(this.btnMostrarLoro);
            this.Controls.Add(this.btnMostrarLeon);
            this.Controls.Add(this.btnAlimentoConejo);
            this.Controls.Add(this.btnAlimentoLoro);
            this.Controls.Add(this.btnAlimentoLeon);
            this.Name = "FrmAnimales";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlimentoLeon;
        private System.Windows.Forms.Button btnAlimentoLoro;
        private System.Windows.Forms.Button btnAlimentoConejo;
        private System.Windows.Forms.Button btnMostrarLeon;
        private System.Windows.Forms.Button btnMostrarLoro;
        private System.Windows.Forms.Button btnMostrarConejo;
    }
}