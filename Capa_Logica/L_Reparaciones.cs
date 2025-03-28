using System.Data;
using Capa_Datos;
using Microsoft.Data.SqlClient;

namespace Capa_Logica
{
    public class L_Reparaciones : Conexion
    {
        public DataTable MostrarReparaciones()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = AbrirConexion()) // Usamos AbrirConexion() de la clase base
            {
                SqlCommand cmd = new SqlCommand("SP_MostrarReparaciones", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public void InsertarReparacion(int equipoID, DateTime fechaSolicitud, string estado)
        {
            using (SqlConnection cn = AbrirConexion()) // Usamos AbrirConexion() de la clase base
            {
                SqlCommand cmd = new SqlCommand("SP_InsertarReparacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EquipoID", equipoID);
                cmd.Parameters.AddWithValue("@FechaSolicitud", fechaSolicitud);
                cmd.Parameters.AddWithValue("@Estado", estado);
                cmd.ExecuteNonQuery();
            }
        }

        public void EditarReparacion(int reparacionID, DateTime fechaSolicitud, string estado)
        {
            using (SqlConnection cn = AbrirConexion()) // Usamos AbrirConexion() de la clase base
            {
                SqlCommand cmd = new SqlCommand("SP_EditarReparacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReparacionID", reparacionID);
                cmd.Parameters.AddWithValue("@FechaSolicitud", fechaSolicitud); // Si es necesario editar la fecha
                cmd.Parameters.AddWithValue("@Estado", estado);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarReparacion(int reparacionID)
        {
            using (SqlConnection cn = AbrirConexion()) // Usamos AbrirConexion() de la clase base
            {
                SqlCommand cmd = new SqlCommand("SP_EliminarReparacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReparacionID", reparacionID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}



