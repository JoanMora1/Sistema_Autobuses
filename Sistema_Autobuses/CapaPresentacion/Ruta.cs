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
    public partial class Ruta : Form
    {
        public Ruta()
        {
            InitializeComponent();
        }

        private string IdRuta;
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
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].Visible = false;
        }
        private void MostrarDatos(string buscar)
        {
            N_Autobus n_Autobus = new N_Autobus();
            dataGridView1.DataSource = n_Autobus.ListarRutas(buscar);
        }
        private void LimpiarCajas()
        {
            editar = false;
            txtNombre.Text = "";
        }

        private void Ruta_Load(object sender, EventArgs e)
        {
            MostrarDatos("");
            OcultarDatos();
        }

        private void btnEditarRuta_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editar = true;
                IdRuta = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
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

        private void btnAgregarRuta_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    e_Autobus.NOMBRE_RUTA = txtNombre.Text;

                    n_Autobus.InsertandoRuta(e_Autobus);
                    MessageBox.Show("Ruta registrada");
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
                    e_Autobus.ID_RUTA = Convert.ToInt32(IdRuta);
                    e_Autobus.NOMBRE_RUTA = txtNombre.Text;

                    n_Autobus.EditandoRuta(e_Autobus);
                    MessageBox.Show("Ruta Editado");
                    MostrarDatos("");
                    LimpiarCajas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar la ruta." + ex);
                }
            }
        }

        private void btnEliminarRuta_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                e_Autobus.ID_RUTA = Convert.ToInt32(dataGridView1.CurrentRow.Cells[12].Value.ToString());
                n_Autobus.EliminandoRuta(e_Autobus);

                MessageBox.Show("Se eliminó la ruta");
                MostrarDatos("");
            }
            else
            {
                MessageBox.Show("Seleccione la fila a eliminar");
            }
        }
    }
}
