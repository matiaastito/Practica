namespace WindowsPresentacion
{
    partial class FrmAjedrez
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
            this.btnMovimientoPeon = new System.Windows.Forms.Button();
            this.btnMovimientoCaballo = new System.Windows.Forms.Button();
            this.btnMovimientoTorre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMovimientoPeon
            // 
            this.btnMovimientoPeon.Location = new System.Drawing.Point(73, 149);
            this.btnMovimientoPeon.Name = "btnMovimientoPeon";
            this.btnMovimientoPeon.Size = new System.Drawing.Size(121, 23);
            this.btnMovimientoPeon.TabIndex = 0;
            this.btnMovimientoPeon.Text = "Movimiento Peon";
            this.btnMovimientoPeon.UseVisualStyleBackColor = true;
            this.btnMovimientoPeon.Click += new System.EventHandler(this.btnMovimientoPeon_Click);
            // 
            // btnMovimientoCaballo
            // 
            this.btnMovimientoCaballo.Location = new System.Drawing.Point(314, 149);
            this.btnMovimientoCaballo.Name = "btnMovimientoCaballo";
            this.btnMovimientoCaballo.Size = new System.Drawing.Size(121, 23);
            this.btnMovimientoCaballo.TabIndex = 1;
            this.btnMovimientoCaballo.Text = "Movimiento Caballo";
            this.btnMovimientoCaballo.UseVisualStyleBackColor = true;
            this.btnMovimientoCaballo.Click += new System.EventHandler(this.btnMovimientoCaballo_Click);
            // 
            // btnMovimientoTorre
            // 
            this.btnMovimientoTorre.Location = new System.Drawing.Point(537, 149);
            this.btnMovimientoTorre.Name = "btnMovimientoTorre";
            this.btnMovimientoTorre.Size = new System.Drawing.Size(121, 23);
            this.btnMovimientoTorre.TabIndex = 2;
            this.btnMovimientoTorre.Text = "Movimiento Torre";
            this.btnMovimientoTorre.UseVisualStyleBackColor = true;
            this.btnMovimientoTorre.Click += new System.EventHandler(this.btnMovimientoTorre_Click);
            // 
            // FrmAjedrez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMovimientoTorre);
            this.Controls.Add(this.btnMovimientoCaballo);
            this.Controls.Add(this.btnMovimientoPeon);
            this.Name = "FrmAjedrez";
            this.Text = "FrmAjedrez";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMovimientoPeon;
        private System.Windows.Forms.Button btnMovimientoCaballo;
        private System.Windows.Forms.Button btnMovimientoTorre;
    }
}