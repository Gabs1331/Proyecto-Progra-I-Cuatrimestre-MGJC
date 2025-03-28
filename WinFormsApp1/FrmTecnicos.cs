using Capa_Logica;

namespace Capa_Presentacion
{
    public partial class FrmTecnicos : Form
        

    {
        L_Tecnicos logica = new L_Tecnicos();
        public FrmTecnicos()
        {
            InitializeComponent();
        }

        private void FrmTecnicos_Load(object sender, EventArgs e)
        {
            MostrarTecnicos();
        }

        private void MostrarTecnicos()
        {
            dgvTecnicos.DataSource = logica.MostrarTecnicos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                logica.InsertarTecnico(
                    Convert.ToInt32(txtTecnicoID.Text),
                    txtNombre.Text,
                    txtEspecialidad.Text
                    
                );
                MessageBox.Show("Técnico guardado exitosamente.");
                MostrarTecnicos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                logica.EditarTecnico(
                    Convert.ToInt32(txtTecnicoID.Text),
                    txtNombre.Text,
                    txtEspecialidad.Text
                    
                );
                MessageBox.Show("Técnico modificado correctamente.");
                MostrarTecnicos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                logica.EliminarTecnico(Convert.ToInt32(txtTecnicoID.Text));
                MessageBox.Show("Técnico eliminado correctamente.");
                MostrarTecnicos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtTecnicoID.Clear();
            txtNombre.Clear();
            txtEspecialidad.Clear();
            
        }

        private void dgvTecnicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTecnicoID.Text = dgvTecnicos.Rows[e.RowIndex].Cells["TecnicoID"].Value.ToString();
                txtNombre.Text = dgvTecnicos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtEspecialidad.Text = dgvTecnicos.Rows[e.RowIndex].Cells["Especialidad"].Value.ToString();
                
            }
        }
        private void txtTecnicoID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEspecialidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvTecnicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}




