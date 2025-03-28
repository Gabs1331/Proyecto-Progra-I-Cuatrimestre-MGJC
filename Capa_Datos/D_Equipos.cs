using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Capa_Datos
{
    public class D_Equipos : Conexion
    {
        public DataTable MostrarEquipos()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand("ConsultarEquipos", AbrirConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al mostrar equipos: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
            return tabla;
        }

        public void InsertarEquipo(int equipoID, string tipoEquipo, string modelo, int usuarioID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("InsertarEquipo", AbrirConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EquipoID", equipoID);
                    cmd.Parameters.AddWithValue("@TipoEquipo", tipoEquipo);
                    cmd.Parameters.AddWithValue("@Modelo", modelo);
                    cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar equipo: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void EditarEquipo(int equipoID, string tipoEquipo, string modelo, int usuarioID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("ModificarEquipo", AbrirConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EquipoID", equipoID);
                    cmd.Parameters.AddWithValue("@TipoEquipo", tipoEquipo);
                    cmd.Parameters.AddWithValue("@Modelo", modelo);
                    cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al editar equipo: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void EliminarEquipo(int equipoID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("EliminarEquipo", AbrirConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EquipoID", equipoID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar equipo: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }
    }
}