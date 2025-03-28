using System;
using System.Data;
using System.Windows.Forms;
using Capa_Logica;

namespace Capa_Presentacion
{
    public partial class FrmAsignaciones : Form
    {
        private L_Asignaciones logica = new L_Asignaciones();

        public FrmAsignaciones()
        {
            InitializeComponent();
      
        }

        private void FrmAsignaciones_Load(object sender, EventArgs e)
        {
            MostrarAsignaciones(); // Cargar las asignaciones al cargar el formulario
        }

        // Método para cargar las asignaciones en el DataGridView
        private void MostrarAsignaciones()
        {
            try
            {
                dgvAsignaciones.DataSource = logica.MostrarAsignaciones(); // Obtener todas las asignaciones
                dgvAsignaciones.Columns["AsignacionID"].Visible = true; // Asegurar que la columna AsignacionID esté visible
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar asignaciones: " + ex.Message);
            }
        }

        // Botón para guardar una nueva asignación
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int reparacionID = Convert.ToInt32(txtReparacionID.Text);
                int tecnicoID = Convert.ToInt32(txtTecnicoID.Text);
                DateTime fechaAsignacion = dtpFechaAsignacion.Value;

                logica.InsertarAsignacion(reparacionID, tecnicoID, fechaAsignacion);
                MessageBox.Show("Asignación guardada exitosamente.");
                MostrarAsignaciones(); // Recargar la lista de asignaciones
                LimpiarCampos(); // Limpiar los campos después de guardar
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la asignación: " + ex.Message);
            }
        }

        // Botón para modificar una asignación existente
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAsignaciones.CurrentRow != null)
                {
                    int asignacionID = Convert.ToInt32(dgvAsignaciones.CurrentRow.Cells["AsignacionID"].Value);
                    int reparacionID = Convert.ToInt32(txtReparacionID.Text);
                    int tecnicoID = Convert.ToInt32(txtTecnicoID.Text);
                    DateTime fechaAsignacion = dtpFechaAsignacion.Value;

                    logica.EditarAsignacion(asignacionID, reparacionID, tecnicoID, fechaAsignacion);
                    MessageBox.Show("Asignación modificada correctamente.");
                    MostrarAsignaciones(); // Recargar la lista de asignaciones
                    LimpiarCampos(); // Limpiar los campos después de modificar
                }
                else
                {
                    MessageBox.Show("Seleccione una asignación para modificar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la asignación: " + ex.Message);
            }
        }

        // Botón para eliminar una asignación existente
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAsignaciones.CurrentRow != null)
                {
                    int asignacionID = Convert.ToInt32(dgvAsignaciones.CurrentRow.Cells["AsignacionID"].Value);
                    logica.EliminarAsignacion(asignacionID);
                    MessageBox.Show("Asignación eliminada correctamente.");
                    MostrarAsignaciones(); // Recargar la lista de asignaciones
                    LimpiarCampos(); // Limpiar los campos después de eliminar
                }
                else
                {
                    MessageBox.Show("Seleccione una asignación para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la asignación: " + ex.Message);
            }
        }

        // Botón para limpiar los campos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Método para limpiar los campos de texto
        private void LimpiarCampos()
        {
            txtReparacionID.Clear();
            txtTecnicoID.Clear();
            dtpFechaAsignacion.Value = DateTime.Now;
        }


        private void dgvAsignaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            
            txtTecnicoID.Text = dgvAsignaciones.Rows[e.RowIndex].Cells["TecnicoID"].Value.ToString();
            txtReparacionID.Text = dgvAsignaciones.Rows[e.RowIndex].Cells["ReparacionID"].Value.ToString();
            dtpFechaAsignacion.Value = Convert.ToDateTime(dgvAsignaciones.CurrentRow.Cells["FechaAsignacion"].Value);
        }

        private void txtTecnicoID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReparacionID_TextChanged(object sender, EventArgs e)
        {

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}


