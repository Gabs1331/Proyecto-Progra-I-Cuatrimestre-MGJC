using Capa_Datos;
using Capa_Logica;
using Microsoft.Data.SqlClient;

namespace Capa_Presentacion
{
    public partial class FrmLogin : Form
    {
        private Conexion conexion = new Conexion(); // Asegúrate de declarar la conexión aquí

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuarioID = txtUsuarioID.Text.Trim();  // txtUsuarioID debe existir en el Designer
            string contrasena = txtContraseña.Text.Trim();  // txtContraseña debe existir en el Designer

            // Crear la instancia de L_Login
            L_Login login = new L_Login();

            // Validar si el acceso es correcto
            bool acceso = login.LoginCorrecto(usuarioID, contrasena);

            if (acceso)
            {
                FrmPrincipal principal = new FrmPrincipal();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuarioID.Clear();
                txtContraseña.Clear();
                txtUsuarioID.Focus();
            }
        }
    }
}

