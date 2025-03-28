using Capa_Logica;
using Capa_Datos;

namespace Capa_Presentacion
{
    public partial class FrmUsuarios : Form
    {
        L_Usuarios logica = new L_Usuarios();
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void MostrarUsuarios()
        {
            try
            {
                dgvUsuarios.DataSource = logica.MostrarUsuarios();
                // Asegura que la columna "UsuarioID" esté visible
                dgvUsuarios.Columns["UsuarioID"].Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                logica.InsertarUsuario(txtNombre.Text, txtCorreo.Text, txtTelefono.Text);
                MessageBox.Show("Usuario guardado exitosamente.");
                MostrarUsuarios();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el usuario: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int usuarioID = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["UsuarioID"].Value);
                logica.EditarUsuario(usuarioID, txtNombre.Text, txtCorreo.Text, txtTelefono.Text);
                MessageBox.Show("Usuario modificado correctamente.");
                MostrarUsuarios();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el usuario: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int usuarioID = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["UsuarioID"].Value);
                logica.EliminarUsuario(usuarioID);
                MessageBox.Show("Usuario eliminado correctamente.");
                MostrarUsuarios();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Rellenamos los campos con los valores de la fila seleccionada en el DataGridView
                txtNombre.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtCorreo.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
                txtTelefono.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtUsuarioID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellClick(DataGridViewCellEventArgs e, object sender)
        {

        }
    }
}


    
