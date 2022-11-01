namespace WindowsPresentacion
{
    partial class FrmMedico
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
            this.btnMedico = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMedico
            // 
            this.btnMedico.Location = new System.Drawing.Point(129, 114);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(119, 21);
            this.btnMedico.TabIndex = 0;
            this.btnMedico.Text = "Medico";
            this.btnMedico.UseVisualStyleBackColor = true;
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.Location = new System.Drawing.Point(348, 114);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(168, 21);
            this.btnPaciente.TabIndex = 1;
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // FrmMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.btnMedico);
            this.Name = "FrmMedico";
            this.Text = "FrmMedico";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.Button btnPaciente;
    }
}