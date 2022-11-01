using LibTransportes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPresentacion
{
    public partial class FrmTransportes : Form
    {
        Avion avion1 = new Avion((decimal)10000, 6, 6000, (decimal)750.6, 400);
        Auto auto1 = new Auto("Toyota Corolla", 50, 180, 5);
        public FrmTransportes()
        {
            InitializeComponent();
        }

        private void btnAcelerarAvion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(avion1.acelerar());
        }

        private void btnDesacelerarAvion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(avion1.desacelerar());
        }

        private void btnAscender_Click(object sender, EventArgs e)
        {
            MessageBox.Show(avion1.ascender());
        }

        private void btnDescender_Click(object sender, EventArgs e)
        {
            MessageBox.Show(avion1.descender());
        }

        private void btnAcelerarAuto_Click(object sender, EventArgs e)
        {
            MessageBox.Show(auto1.acelerar());
        }

        private void btnDesacelerarAuto_Click(object sender, EventArgs e)
        {
            MessageBox.Show(auto1.desacelerar());
        }

        private void btnDoblarIzq_Click(object sender, EventArgs e)
        {
            MessageBox.Show(auto1.doblarAIzq());
        }

        private void btnDoblarDerecha_Click(object sender, EventArgs e)
        {
            MessageBox.Show(auto1.doblarADer());
        }
    }
}
