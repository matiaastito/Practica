namespace WindowsPresentacion
{
    partial class FrmTransportes
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
            this.btnAcelerarAvion = new System.Windows.Forms.Button();
            this.btnDescender = new System.Windows.Forms.Button();
            this.btnAscender = new System.Windows.Forms.Button();
            this.btnDesacelerarAvion = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDoblarDerecha = new System.Windows.Forms.Button();
            this.btnDoblarIzq = new System.Windows.Forms.Button();
            this.btnDesacelerarAuto = new System.Windows.Forms.Button();
            this.btnAcelerarAuto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAcelerarAvion
            // 
            this.btnAcelerarAvion.Location = new System.Drawing.Point(103, 137);
            this.btnAcelerarAvion.Name = "btnAcelerarAvion";
            this.btnAcelerarAvion.Size = new System.Drawing.Size(75, 23);
            this.btnAcelerarAvion.TabIndex = 1;
            this.btnAcelerarAvion.Text = "Acelerar";
            this.btnAcelerarAvion.UseVisualStyleBackColor = true;
            this.btnAcelerarAvion.Click += new System.EventHandler(this.btnAcelerarAvion_Click);
            // 
            // btnDescender
            // 
            this.btnDescender.Location = new System.Drawing.Point(103, 293);
            this.btnDescender.Name = "btnDescender";
            this.btnDescender.Size = new System.Drawing.Size(75, 23);
            this.btnDescender.TabIndex = 6;
            this.btnDescender.Text = "Descender";
            this.btnDescender.UseVisualStyleBackColor = true;
            this.btnDescender.Click += new System.EventHandler(this.btnDescender_Click);
            // 
            // btnAscender
            // 
            this.btnAscender.Location = new System.Drawing.Point(103, 236);
            this.btnAscender.Name = "btnAscender";
            this.btnAscender.Size = new System.Drawing.Size(75, 23);
            this.btnAscender.TabIndex = 5;
            this.btnAscender.Text = "Ascender";
            this.btnAscender.UseVisualStyleBackColor = true;
            this.btnAscender.Click += new System.EventHandler(this.btnAscender_Click);
            // 
            // btnDesacelerarAvion
            // 
            this.btnDesacelerarAvion.Location = new System.Drawing.Point(103, 181);
            this.btnDesacelerarAvion.Name = "btnDesacelerarAvion";
            this.btnDesacelerarAvion.Size = new System.Drawing.Size(75, 23);
            this.btnDesacelerarAvion.TabIndex = 4;
            this.btnDesacelerarAvion.Text = "Desacelerar";
            this.btnDesacelerarAvion.UseVisualStyleBackColor = true;
            this.btnDesacelerarAvion.Click += new System.EventHandler(this.btnDesacelerarAvion_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsPresentacion.Properties.Resources.avion;
            this.pictureBox2.Location = new System.Drawing.Point(64, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::WindowsPresentacion.Properties.Resources.Auto;
            this.pictureBox1.Location = new System.Drawing.Point(469, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnDoblarDerecha
            // 
            this.btnDoblarDerecha.Location = new System.Drawing.Point(525, 293);
            this.btnDoblarDerecha.Name = "btnDoblarDerecha";
            this.btnDoblarDerecha.Size = new System.Drawing.Size(75, 38);
            this.btnDoblarDerecha.TabIndex = 12;
            this.btnDoblarDerecha.Text = "Doblar a la derecha";
            this.btnDoblarDerecha.UseVisualStyleBackColor = true;
            this.btnDoblarDerecha.Click += new System.EventHandler(this.btnDoblarDerecha_Click);
            // 
            // btnDoblarIzq
            // 
            this.btnDoblarIzq.Location = new System.Drawing.Point(525, 236);
            this.btnDoblarIzq.Name = "btnDoblarIzq";
            this.btnDoblarIzq.Size = new System.Drawing.Size(75, 38);
            this.btnDoblarIzq.TabIndex = 11;
            this.btnDoblarIzq.Text = "Doblar a la Izquierda";
            this.btnDoblarIzq.UseVisualStyleBackColor = true;
            this.btnDoblarIzq.Click += new System.EventHandler(this.btnDoblarIzq_Click);
            // 
            // btnDesacelerarAuto
            // 
            this.btnDesacelerarAuto.Location = new System.Drawing.Point(525, 181);
            this.btnDesacelerarAuto.Name = "btnDesacelerarAuto";
            this.btnDesacelerarAuto.Size = new System.Drawing.Size(75, 23);
            this.btnDesacelerarAuto.TabIndex = 10;
            this.btnDesacelerarAuto.Text = "Desacelerar";
            this.btnDesacelerarAuto.UseVisualStyleBackColor = true;
            this.btnDesacelerarAuto.Click += new System.EventHandler(this.btnDesacelerarAuto_Click);
            // 
            // btnAcelerarAuto
            // 
            this.btnAcelerarAuto.Location = new System.Drawing.Point(525, 137);
            this.btnAcelerarAuto.Name = "btnAcelerarAuto";
            this.btnAcelerarAuto.Size = new System.Drawing.Size(75, 23);
            this.btnAcelerarAuto.TabIndex = 9;
            this.btnAcelerarAuto.Text = "Acelerar";
            this.btnAcelerarAuto.UseVisualStyleBackColor = true;
            this.btnAcelerarAuto.Click += new System.EventHandler(this.btnAcelerarAuto_Click);
            // 
            // FrmTransportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDoblarDerecha);
            this.Controls.Add(this.btnDoblarIzq);
            this.Controls.Add(this.btnDesacelerarAuto);
            this.Controls.Add(this.btnAcelerarAuto);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnDescender);
            this.Controls.Add(this.btnAscender);
            this.Controls.Add(this.btnDesacelerarAvion);
            this.Controls.Add(this.btnAcelerarAvion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmTransportes";
            this.Text = "FrmTransportes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAcelerarAvion;
        private System.Windows.Forms.Button btnDescender;
        private System.Windows.Forms.Button btnAscender;
        private System.Windows.Forms.Button btnDesacelerarAvion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDoblarDerecha;
        private System.Windows.Forms.Button btnDoblarIzq;
        private System.Windows.Forms.Button btnDesacelerarAuto;
        private System.Windows.Forms.Button btnAcelerarAuto;
    }
}