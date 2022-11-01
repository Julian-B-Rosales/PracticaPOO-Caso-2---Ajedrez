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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMoverPeon_Click(object sender, EventArgs e)
        {
            Peon peon = new Peon();

            MessageBox.Show(peon.Mover());
        }

        private void btnMoverCaballo_Click(object sender, EventArgs e)
        {
            Caballo caballo = new Caballo();

            MessageBox.Show(caballo.Mover());
        }

        private void btnMoverTorre_Click(object sender, EventArgs e)
        {
            Torre torre = new Torre();

            MessageBox.Show(torre.Mover());
        }
    }
}
