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
    public partial class FrmDetallesReparacion : Form
    {
        L_DetallesReparacion logica = new L_DetallesReparacion();
        public FrmDetallesReparacion()
        {
            InitializeComponent();
        }

        private void FrmDetallesReparacion_Load(object sender, EventArgs e)
        {
            MostrarDetalles();
        }

        private void MostrarDetalles()
        {
            dgvDetalles.DataSource = logica.MostrarDetalles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que las fechas sean correctas antes de insertarlas
            if (DateTime.TryParse(txtFechaInicio.Text, out DateTime fechaInicio) &&
                DateTime.TryParse(txtFechaFin.Text, out DateTime fechaFin))
            {
                logica.InsertarDetalle(
                    Convert.ToInt32(txtDetalleID.Text),
                    Convert.ToInt32(txtReparacionID.Text),
                    fechaInicio,
                    fechaFin,
                    txtDescripcion.Text
                );
                MessageBox.Show("Detalle guardado.");
                MostrarDetalles();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Las fechas ingresadas no son válidas.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Validar que las fechas sean correctas antes de modificarlas
            if (DateTime.TryParse(txtFechaInicio.Text, out DateTime fechaInicio) &&
                DateTime.TryParse(txtFechaFin.Text, out DateTime fechaFin))
            {
                logica.EditarDetalle(
                    Convert.ToInt32(txtDetalleID.Text),
                    Convert.ToInt32(txtReparacionID.Text),
                    fechaInicio,
                    fechaFin,
                    txtDescripcion.Text
                );
                MessageBox.Show("Detalle modificado.");
                MostrarDetalles();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Las fechas ingresadas no son válidas.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            logica.EliminarDetalle(Convert.ToInt32(txtDetalleID.Text));
            MessageBox.Show("Detalle eliminado.");
            MostrarDetalles();
            LimpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtDetalleID.Clear();
            txtReparacionID.Clear();
            txtDescripcion.Clear();
            txtFechaInicio.Clear();
            txtFechaFin.Clear();
        }

        private void dgvDetalles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtDetalleID.Text = dgvDetalles.Rows[e.RowIndex].Cells["DetalleID"].Value.ToString();
                txtReparacionID.Text = dgvDetalles.Rows[e.RowIndex].Cells["ReparacionID"].Value.ToString();
                txtDescripcion.Text = dgvDetalles.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                txtFechaInicio.Text = dgvDetalles.Rows[e.RowIndex].Cells["FechaInicio"].Value.ToString();
                txtFechaFin.Text = dgvDetalles.Rows[e.RowIndex].Cells["FechaFin"].Value.ToString();
            }
        }
    }
}

