using LibreriasPoo.Models;
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
    public partial class FrmInstrumentos : Form
    {
        public FrmInstrumentos()
        {
            InitializeComponent();
        }

        private void btnAfinarGuitarra_Click(object sender, EventArgs e)
        {
            Guitarra guitarra = new Guitarra("Madera",true, "Beta","Cuerda Pulsada");
            MessageBox.Show(guitarra.AfinarInstrumento());

        }

        private void btnAfinarViolin_Click(object sender, EventArgs e)
        {
            Violin violin = new Violin("Madera", 4, "Alfa", "Cuerda Frotada");
            MessageBox.Show(violin.AfinarInstrumento());
        }

        private void btnAfinarPiano_Click(object sender, EventArgs e)
        {
            Piano piano = new Piano(false, "Alfa", "Cuerda Percutida");
            MessageBox.Show(piano.AfinarInstrumento());
        }
    }
}
