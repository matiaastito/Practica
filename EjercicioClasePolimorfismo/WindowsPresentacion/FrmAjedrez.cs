using LibAjedrez.Models;
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
    public partial class FrmAjedrez : Form
    {
        Torre torre = new Torre((decimal)0.6, "Madera");
        Caballo caballo = new Caballo((decimal)0.6, "Madera");
        Peon peon = new Peon((decimal)0.6, "Madera");
        public FrmAjedrez()
        {
            InitializeComponent();
        }

        private void btnMovimientoPeon_Click(object sender, EventArgs e)
        {
            MessageBox.Show(peon.Mover());
        }

        private void btnMovimientoCaballo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(caballo.Mover());
        }

        private void btnMovimientoTorre_Click(object sender, EventArgs e)
        {
            MessageBox.Show(torre.Mover());
        }
    }
}
