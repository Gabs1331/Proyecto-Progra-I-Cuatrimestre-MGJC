using Capa_Datos;
using Capa_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class FrmEquipos : Form
    {
        L_Equipos logica = new L_Equipos();
        public FrmEquipos()
        {
            InitializeComponent();
        }
        private void MostrarEquipos()
        {
            dgvEquipos.DataSource = logica.MostrarEquipos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            logica.InsertarEquipo(
                Convert.ToInt32(txtEquipoID.Text),
                txtDescripcion.Text,
                txtModelo.Text,
                Convert.ToInt32(txtUsuarioID.Text)
            );
            MessageBox.Show("Equipo guardado.");
            MostrarEquipos();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            logica.EditarEquipo(
                Convert.ToInt32(txtEquipoID.Text),
                txtDescripcion.Text,
                txtModelo.Text,
                Convert.ToInt32(txtUsuarioID.Text)
            );
            MessageBox.Show("Equipo modificado.");
            MostrarEquipos();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            logica.EliminarEquipo(Convert.ToInt32(txtEquipoID.Text));
            MessageBox.Show("Equipo eliminado.");
            MostrarEquipos();
            LimpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtEquipoID.Clear();
            txtDescripcion.Clear();
            txtModelo.Clear();
            txtUsuarioID.Clear();
        }

        private void dgvEquipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtEquipoID.Text = dgvEquipos.Rows[e.RowIndex].Cells["EquipoID"].Value.ToString();
                txtDescripcion.Text = dgvEquipos.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                txtModelo.Text = dgvEquipos.Rows[e.RowIndex].Cells["Modelo"].Value.ToString();
                txtUsuarioID.Text = dgvEquipos.Rows[e.RowIndex].Cells["UsuarioID"].Value.ToString();
            }

        }

        private void txtEquipoID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuarioID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmEquipos_Load(object sender, EventArgs e)
        {

        }
    }
}




    
