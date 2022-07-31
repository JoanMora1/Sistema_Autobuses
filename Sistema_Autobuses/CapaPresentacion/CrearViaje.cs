using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class CrearViaje : Form
    {
        public CrearViaje()
        {
            InitializeComponent();
        }

        E_Autobus e_Autobus = new E_Autobus();
        N_Autobus n_Autobus = new N_Autobus();

        public void MostrarDatos(string buscar)
        {
            N_Autobus n_Autobus = new N_Autobus();
            dataGridView1.DataSource = n_Autobus.ListarViaje(buscar);
        }

        private void LimpiarCajas()
        {
            ComboChofer.Text = "";
            ComboAutobus.Text = "";
            ComboRuta.Text = "";
        }
        private void OcultarDatos()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
        }

        private void CrearViaje_Load(object sender, EventArgs e)
        {
            ComboChofer.DataSource = n_Autobus.cbxChofer();
            ComboChofer.DisplayMember = "NOMBRE";
            ComboChofer.ValueMember = "NOMBRE";
            ComboChofer.SelectedIndex = -1;

            ComboAutobus.DataSource = n_Autobus.cbxAutobus();
            ComboAutobus.DisplayMember = "MODELO";
            ComboAutobus.ValueMember = "PLACA";
            ComboAutobus.SelectedIndex = -1;

            ComboRuta.DataSource = n_Autobus.cbxRuta();
            ComboRuta.DisplayMember = "RUTAS";
            ComboRuta.ValueMember = "RUTAS";
            ComboRuta.SelectedIndex = -1;

            MostrarDatos("");
            OcultarDatos();
        }

        private void btnAgregarViaje_Click(object sender, EventArgs e)
        {
            e_Autobus.CHOFER = ComboChofer.Text.ToUpper();
            e_Autobus.AUTOBUS = ComboAutobus.Text.ToUpper();
            e_Autobus.RUTA = ComboRuta.Text.ToUpper();

            n_Autobus.InsertandoViaje(e_Autobus);
            n_Autobus.DisponibilidadChofer(e_Autobus);
            n_Autobus.DisponibilidadAutobus(e_Autobus);
            n_Autobus.DisponibilidadRuta(e_Autobus);

            MessageBox.Show("Se inicio el viaje con exito.");

            LimpiarCajas();
            CrearViaje_Load(sender, e);
            MostrarDatos("");

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
