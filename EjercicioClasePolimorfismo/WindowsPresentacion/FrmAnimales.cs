using LibAnimales.Animales;
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
    public partial class FrmAnimales : Form
    {
        Loro loro = new Loro("Vegetales", (decimal)5.25, (decimal)0.45, 7);
        Leon leon = new Leon("Carne", (decimal)80.2, (decimal)1.0, 10);
        Conejo conejo = new Conejo("Pasto y verduras", (decimal)10.55, (decimal)0.65, 3);
        public FrmAnimales()
        {
            InitializeComponent();
        }

        private void btnAlimentarLeon_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show(leon.ImprimirComida());
        }
        private void btnAlimentarConejo_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(conejo.ImprimirComida());
        }
        private void btnAlimentarLoro_Click(object sender, EventArgs e)
        {
 
            MessageBox.Show(loro.ImprimirComida());
        }

        private void btnMostrarLeon_Click(object sender, EventArgs e)
        {
            MessageBox.Show(leon.Imprimir());
        }

        private void btnMostrarLoro_Click(object sender, EventArgs e)
        {
            MessageBox.Show(loro.Imprimir());
        }

        private void btnMostrarConejo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conejo.Imprimir());
        }
    }
}
