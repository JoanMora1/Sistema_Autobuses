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
    public partial class Chofer : Form
    {
        public Chofer()
        {
            InitializeComponent();
        }

        public string IdChofer;
        public bool editar = false;

        E_Autobus e_Autobus = new E_Autobus();
        N_Autobus n_Autobus = new N_Autobus();

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        public void MostarDatos(string buscar)
        {
            N_Autobus n_Autobus = new N_Autobus();
            dataGridView1.DataSource = n_Autobus.ListarChofer(buscar);
        }

        private void OcultarDatos()
        {
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].Visible = false;
        }

        private void LimpiarCaja()
        {
            editar = false;
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCedula.Text = "";
        }

        private void btnAgregarChofer_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    e_Autobus.NOMBRE = txtNombre.Text;
                    e_Autobus.APELLIDO = txtApellido.Text;
                    e_Autobus.NACIMIENTO = dateTimePicker1.Value;
                    e_Autobus.CEDULA = txtCedula.Text;

                    n_Autobus.InsertandoChofer(e_Autobus);
                    MessageBox.Show("Agregado con Exito.");
                    MostarDatos("");
                    LimpiarCaja();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo registrar " + ex);
                }
            }
            if (editar == true)
            {
                try
                {
                    e_Autobus.ID_CHOFER = Convert.ToInt32(IdChofer);
                    e_Autobus.NOMBRE = txtNombre.Text;
                    e_Autobus.APELLIDO = txtApellido.Text;
                    e_Autobus.NACIMIENTO = dateTimePicker1.Value;
                    e_Autobus.CEDULA = txtCedula.Text;

                    n_Autobus.EditandoChofer(e_Autobus);
                    MessageBox.Show("Chofer Editado");
                    MostarDatos("");
                    LimpiarCaja();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el chofer." + ex);
                }
            }
        }

        private void Chofer_Load(object sender, EventArgs e)
        {
            MostarDatos("");
            OcultarDatos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostarDatos(txtBuscar.Text);
        }

        private void btnEditarChofer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editar = true;
                IdChofer = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtCedula.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }
        }

        private void btnEliminarChofer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                e_Autobus.ID_CHOFER = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                n_Autobus.EliminandoChofer(e_Autobus);

                MessageBox.Show("Se eliminó con exito.");
                MostarDatos("");
            }
            else
            {
                MessageBox.Show("Seleccione el chofer que desea eliminar.");
            }
        }
    }
}
