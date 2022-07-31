using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChofer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chofer chofer = new Chofer();
            chofer.Show();
        }

        private void btnAutobus_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autobus autobus = new Autobus();
            autobus.Show();
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ruta ruta = new Ruta();
            ruta.Show();
        }

        private void btnIniciarViaje_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearViaje crearViaje = new CrearViaje();
            crearViaje.Show();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FinViaje finViaje = new FinViaje();
            finViaje.Show();
        }
    }
}
