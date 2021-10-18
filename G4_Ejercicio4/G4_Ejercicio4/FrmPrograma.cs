using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G4_Ejercicio4
{
    public partial class FrmPrograma : Form
    {
        public FrmPrograma()
        {
            InitializeComponent();
        }

        private void btncrearvehiculo_Click(object sender, EventArgs e)
        {

        }

        private void btnsalirprogram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPrograma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
