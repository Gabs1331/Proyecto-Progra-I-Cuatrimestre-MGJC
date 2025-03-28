using Microsoft.Data.SqlClient;
using System.Data;

namespace Capa_Datos
{
    public class D_Usuarios : Conexion
    {
        // Método para mostrar los usuarios
        public DataTable MostrarUsuarios()
        {
            DataTable tabla = new DataTable();
            SqlConnection cn = null;

            try
            {
                cn = AbrirConexion();  // Usamos el método AbrirConexion de la clase base
                SqlDataAdapter da = new SqlDataAdapter("ConsultarUsuarios", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(tabla);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al mostrar usuarios: {ex.Message}");
            }
            finally
            {
                // Asegurarse de cerrar la conexión después de usarla
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            return tabla;
        }

        // Método para insertar un usuario
        public void InsertarUsuario(string nombre, string correo, string telefono)
        {
            SqlConnection cn = null;

            try
            {
                cn = AbrirConexion();  // Usamos el método AbrirConexion de la clase base
                SqlCommand cmd = new SqlCommand("InsertarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@CorreoElectronico", correo);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar usuario: {ex.Message}");
            }
            finally
            {
                // Asegurarse de cerrar la conexión después de usarla
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        // Método para editar un usuario
        public void EditarUsuario(int usuarioID, string nombre, string correo, string telefono)
        {
            SqlConnection cn = null;

            try
            {
                cn = AbrirConexion();  // Usamos el método AbrirConexion de la clase base
                SqlCommand cmd = new SqlCommand("ModificarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@CorreoElectronico", correo);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al editar usuario: {ex.Message}");
            }
            finally
            {
                // Asegurarse de cerrar la conexión después de usarla
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        // Método para eliminar un usuario
        public void EliminarUsuario(int usuarioID)
        {
            SqlConnection cn = null;

            try
            {
                cn = AbrirConexion();  // Usamos el método AbrirConexion de la clase base
                SqlCommand cmd = new SqlCommand("EliminarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar usuario: {ex.Message}");
            }
            finally
            {
                // Asegurarse de cerrar la conexión después de usarla
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }
    }
}



