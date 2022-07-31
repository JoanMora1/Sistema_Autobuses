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
    public partial class FinViaje : Form
    {
        public FinViaje()
        {
            InitializeComponent();
        }

        E_Autobus e_Autobus = new E_Autobus();
        N_Autobus n_Autobus = new N_Autobus();

        public void MostarDatos(string buscar)
        {
            N_Autobus n_Autobus = new N_Autobus();
            dataGridView1.DataSource = n_Autobus.ListarViaje(buscar);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void FinViaje_Load(object sender, EventArgs e)
        {
            MostarDatos("");
            OcultarDatos();
        }

        private void btnEliminarViaje_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                e_Autobus.ID_VIAJE = Convert.ToInt32(dataGridView1.CurrentRow.Cells[14].Value.ToString());
                e_Autobus.CHOFER = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                e_Autobus.AUTOBUS = dataGridView1.CurrentRow.Cells[16].Value.ToString();
                e_Autobus.RUTA = dataGridView1.CurrentRow.Cells[17].Value.ToString();

                n_Autobus.FinViaje(e_Autobus);
                n_Autobus.DisponibilidadChoferV(e_Autobus);
                n_Autobus.DisponibilidadAutobusV(e_Autobus);
                n_Autobus.DisponibilidadRutaV(e_Autobus);

                MessageBox.Show("El viaje a finalizado.");
                MostarDatos("");
            }
            else
            {
                MessageBox.Show("Seleccione el viaje que quiere finalizar.");
            }
        }
    }
}
