using System.Data;
using Microsoft.Data.SqlClient;
using Capa_Datos;

namespace Capa_Logica
{
    public class L_DetallesReparacion : Conexion
    {
        public DataTable MostrarDetalles()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = AbrirConexion()) // Usamos AbrirConexion() de la clase base
            {
                SqlCommand cmd = new SqlCommand("SP_MostrarDetallesReparacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public void InsertarDetalle(int reparacionID, int v, string descripcion, DateTime fechaInicio, DateTime fechaFin)
        {
            using (SqlConnection cn = AbrirConexion()) // Usamos AbrirConexion() de la clase base
            {
                SqlCommand cmd = new SqlCommand("SP_InsertarDetalleReparacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReparacionID", reparacionID);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
                cmd.ExecuteNonQuery();
            }
        }

        public void EditarDetalle(int detalleID, int v, DateTime dateTime, string descripcion, DateTime fechaFin)
        {
            using (SqlConnection cn = AbrirConexion()) // Usamos AbrirConexion() de la clase base
            {
                SqlCommand cmd = new SqlCommand("SP_EditarDetalleReparacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DetalleID", detalleID);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarDetalle(int detalleID)
        {
            using (SqlConnection cn = AbrirConexion()) // Usamos AbrirConexion() de la clase base
            {
                SqlCommand cmd = new SqlCommand("SP_EliminarDetalleReparacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DetalleID", detalleID);
                cmd.ExecuteNonQuery();
            }
        }

        public void EditarDetalle(int v1, int v2, DateTime fechaInicio, DateTime fechaFin, string text)
        {
            throw new NotImplementedException();
        }

        public void InsertarDetalle(int v1, int v2, DateTime fechaInicio, DateTime fechaFin, string text)
        {
            throw new NotImplementedException();
        }
    }
}

