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
    public partial class Autobus : Form
    {
        public Autobus()
        {
            InitializeComponent();
        }

        private string IdAutobus;
        private bool editar = false;

        E_Autobus e_Autobus = new E_Autobus();
        N_Autobus n_Autobus = new N_Autobus();

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
        private void OcultarDatos()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].Visible = false;
        }
        private void MostrarDatos(string buscar)
        {
            N_Autobus n_Autobus = new N_Autobus();
            dataGridView1.DataSource = n_Autobus.ListarAutobus(buscar);
        }
        private void LimpiarCajas()
        {
            editar = false;
            txtAño.Text = "";
            txtMarca.Text = "";
            txtColor.Text = "";
            txtModelo.Text = "";
            txtPlaca.Text = "";
        }

        private void Autobus_Load(object sender, EventArgs e)
        {
            MostrarDatos("");
            OcultarDatos();
        }

        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    e_Autobus.MARCA = txtMarca.Text;
                    e_Autobus.MODELO = txtModelo.Text;
                    e_Autobus.PLACA = txtPlaca.Text;
                    e_Autobus.COLOR = txtColor.Text;
                    e_Autobus.ANO = txtAño.Text;

                    n_Autobus.InsertandoAutobus(e_Autobus);
                    MessageBox.Show("Autobus registrado");
                    MostrarDatos("");
                    LimpiarCajas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo regitrar" + ex);
                }
            }
            if (editar == true)
            {
                try
                {
                    e_Autobus.ID_AUTOBUS = Convert.ToInt32(IdAutobus);
                    e_Autobus.MARCA = txtMarca.Text;
                    e_Autobus.MODELO = txtModelo.Text;
                    e_Autobus.PLACA = txtPlaca.Text;
                    e_Autobus.COLOR = txtColor.Text;
                    e_Autobus.ANO = txtAño.Text;

                    n_Autobus.EditandoAutobus(e_Autobus);
                    MessageBox.Show("Autobus Editado");
                    MostrarDatos("");
                    LimpiarCajas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el autobus." + ex);
                }
            }
        }

        private void btnEditarAuto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editar = true;
                IdAutobus = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtMarca.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtModelo.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txtPlaca.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                txtColor.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                txtAño.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar.");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarDatos(txtBuscar.Text);
        }

        private void btnEliminarAuto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                e_Autobus.ID_AUTOBUS = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value.ToString());
                n_Autobus.EliminandoAutobus(e_Autobus);

                MessageBox.Show("Se eliminó el autobus");
                MostrarDatos("");
            }
            else
            {
                MessageBox.Show("Seleccione la fila a eliminar");
            }
        }
    }
}
