using LibMedico.Models;
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
    public partial class FrmMedico : Form
    {

        Medico medico = new Medico("Oncologo", "Matias");
        Paciente paciente = new Paciente("AB12345", "Tito");
        public FrmMedico()
        {
            InitializeComponent();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            MessageBox.Show(medico.ToString());
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            MessageBox.Show(paciente.ToString());
        }
    }
}
