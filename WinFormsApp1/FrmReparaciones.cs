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
    public partial class FrmReparaciones : Form
    {
        L_Reparaciones logica = new L_Reparaciones();

        public FrmReparaciones()
        {
            InitializeComponent();
        }
        private void FrmReparaciones_Load(object sender, EventArgs e)
        {
            MostrarReparaciones();
        }

        private void MostrarReparaciones()
        {
            dgvReparaciones.DataSource = logica.MostrarReparaciones();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            logica.InsertarReparacion(
                Convert.ToInt32(txtEquipoID.Text),  // Asegúrate de que el EquipoID es un número entero
                DateTime.Parse(txtFechaSolicitud.Text),  // Convierte correctamente la fecha
                txtEstado.Text  // Estado es un string
            );
            MessageBox.Show("Reparación guardada.");
            MostrarReparaciones();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            logica.EditarReparacion(
                Convert.ToInt32(txtReparacionID.Text),  // ID de la reparación
                DateTime.Parse(txtFechaSolicitud.Text),  // Convierte correctamente la fecha
                txtEstado.Text  // Estado es un string
            );
            MessageBox.Show("Reparación modificada.");
            MostrarReparaciones();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            logica.EliminarReparacion(Convert.ToInt32(txtReparacionID.Text));
            MessageBox.Show("Reparación eliminada.");
            MostrarReparaciones();
            LimpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtReparacionID.Clear();
            txtEquipoID.Clear();
            txtFechaSolicitud.Clear();

            txtEstado.Clear();
        }

        private void dgvReparaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtReparacionID.Text = dgvReparaciones.Rows[e.RowIndex].Cells["ReparacionID"].Value.ToString();
                txtEquipoID.Text = dgvReparaciones.Rows[e.RowIndex].Cells["EquipoID"].Value.ToString();
                txtFechaSolicitud.Text = dgvReparaciones.Rows[e.RowIndex].Cells["FechaInicio"].Value.ToString();
                txtEstado.Text = dgvReparaciones.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
            }
        }

        private void txtReparacionID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEquipoID_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmReparaciones_Load_1(object sender, EventArgs e)
        {

        }

        private void txtFechaSolicitud_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvReparaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}




