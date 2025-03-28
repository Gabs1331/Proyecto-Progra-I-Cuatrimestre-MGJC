using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using Microsoft.Data.SqlClient;

namespace Capa_Datos
{
    public class D_Login : Conexion
    {
        public bool ValidarUsuario(string usuarioID, string contrasena)
        {
            try
            {
                using (SqlConnection cn = ObtenerConexion()) // Usamos el método de la clase base
                {
                    cn.Open(); // Abre la conexión

                    // Configurar el comando para ejecutar el procedimiento almacenado
                    SqlCommand cmd = new SqlCommand("ValidarLogin", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Agregar parámetros
                    cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                    cmd.Parameters.AddWithValue("@Contraseña", contrasena);

                    // Ejecutar y obtener resultado
                    var result = cmd.ExecuteScalar();

                    // Verificar si el resultado es nulo
                    if (result == null)
                    {
                        Debug.WriteLine("Resultado nulo. Usuario o contraseña incorrectos.");
                        return false;
                    }

                    string resultadoTexto = result.ToString().Trim();
                    Debug.WriteLine("Resultado de ValidarLogin: " + resultadoTexto);

                    // Comparar resultado esperado
                    return resultadoTexto == "Acceso Concedido";
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error en ValidarUsuario: " + ex.Message);
                return false;
            }
        }
    }
}





